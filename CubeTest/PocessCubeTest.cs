using System;
using CubeSummation.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubeTest
{
    [TestClass]
    public class PocessCubeTest
    {
        [TestMethod]
        public void TestProcessCube()
        {
            String prueba = "2\n4 5\nUPDATE 2 2 2 4\nQUERY 1 1 1 3 3 3\nUPDATE 1 1 1 23\nQUERY 2 2 2 4 4 4\nQUERY 1 1 1 3 3 3\n2 4\nUPDATE 2 2 2 1\nQUERY 1 1 1 1 1 1\nQUERY 1 1 1 2 2 2\nQUERY 2 2 2 2 2 2";
            String resEsperada = "4\n4\n27\n0\n1\n1\n";
            MODProcessCube cube = new MODProcessCube(prueba);
            cube.AddDataCube();
            String r = cube.respuesta;

            Assert.AreEqual(resEsperada, r);


        }

        [TestMethod]
        public void TestCubeSum()
        {
            double expectedAns = 11;
            double[,,] cubeIn = new double[4, 4, 4];
            cubeIn[0, 0, 0] = 5;
            cubeIn[1, 1, 1] = 6;

            String[] comand = new string[7];
            
            comand[1] = "1";
            comand[2] = "1";
            comand[3] = "1";
            comand[4] = "2";
            comand[5] = "2";
            comand[6] = "2";

            MODProcessCube cube = new MODProcessCube();
            double ans = cube.CubeSum(comand, cubeIn);


            Assert.AreEqual(expectedAns, ans);


        }
    }
}
