using CubeSummation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CubeSummation.Controllers
{
    public class CubeController : Controller
    {
        // GET: Cube
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cube/Details/5
        public ActionResult Details(MODProcessCube cube)
        {
            return View(cube);
        }

        // GET: Cube/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cube/Create
        [HttpPost]
        public ActionResult Create(MODProcessCube cube)
        {
            try
            {
                // TODO: Add insert logic here
                String respuesta = "";
                if (!cube.txtTest.Equals(""))
                {
                    cube.AddDataCube();
                   

                }
                else
                {

                }

                return View("Details", cube);
            }
            catch
            {
                return View();
            }
        }

        // GET: Cube/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cube/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cube/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cube/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
