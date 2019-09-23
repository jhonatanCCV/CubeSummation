using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace CubeSummation.Models
{
    public class MODProcessCube
    {

        [Display(Name = "Comandos")]
        [Required]
        public String txtTest { get; set; }
        
        public String response { get; set; }

        private double[,,] cube;

        public MODProcessCube()
        {
            this.response = "";
        }

        public MODProcessCube(String test)
        {
            this.txtTest = test;
            
        }


        public void AddDataCube()
        {
            String ansData = "";
            byte[] byteArray = Encoding.ASCII.GetBytes(txtTest);
            Stream sreader = new MemoryStream(byteArray);
            StreamReader sr = new StreamReader(sreader);

            int T = Convert.ToInt32(sr.ReadLine());
            String [] config = sr.ReadLine().Split(' ');

            int N = Convert.ToInt32(config[0]);
            int M = Convert.ToInt32(config[1]);

            if (T > 0 && T <= 50 && N >= 1 && N <= 100 && M >=1 && M <= 1000)
            {
               
                for (int i = 0; i < T; i++ )
                {
                    cube = new double[N, N, N];

                    for (int j = 0; j < M; j++)
                    {
                        String[] comand = sr.ReadLine().Split(' ');
                        if (comand[0].Equals("UPDATE"))
                        {
                            int x = Convert.ToInt32(comand[1])-1;
                            int y = Convert.ToInt32(comand[2])-1;
                            int z = Convert.ToInt32(comand[3])-1;
                            Double w = Convert.ToInt32(comand[4]);

                            cube[x, y, z] = w;
                            
                        }
                        else if(comand[0].Equals("QUERY"))
                        {
                            double suma = CubeSum(comand, cube);
                            ansData += suma + "\n";
                        }


                    }
                }
            }
            else
            {
                response = "No puede hacer más de 50 pruebas, el taaño de la matriz debe ser menor a 50 y mayor a 1, ";
            }


            response = resDatos;
         

//            return respuesta;
        }


        public double CubeSum(String[] comand, double[,,] cube)
        {
            double sum = 0;
            int x1 = Convert.ToInt32(comand[1]) - 1;
            int y1 = Convert.ToInt32(comand[2]) - 1;
            int z1 = Convert.ToInt32(comand[3]) - 1;
            int x2 = Convert.ToInt32(comand[4]) - 1;
            int y2 = Convert.ToInt32(comand[5]) - 1;
            int z2 = Convert.ToInt32(comand[6]) - 1;


                for (int x = x1; x <= x2; x++)
                    for (int y = y1; y <= y2; y++)
                        for (int z = z1; z <= z2; z++)
                            sum += cube[x, y, z];
           

            return sum;

        } 


    }
}