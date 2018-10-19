using Helpers;
using Models;
using Models.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;


namespace Client.Controllers
{
    public class CalculateController : Controller
    {
        private static readonly ClientHelper httpClient = new ClientHelper();

        // GET: Calculate
        public ActionResult Index()
        {
            var shapeViewModel = new ShapeViewModel();
            return View(shapeViewModel);
        }

        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> Index(ShapeViewModel shapeViewModel)
        {

            HttpResponseMessage response = await httpClient.PostAsyncAsJson("Calculate/Determine", shapeViewModel);

            if (response.IsSuccessStatusCode)
            {
                shapeViewModel.ShapeType = await response.Content.ReadAsStringAsync();
            }

            return View(shapeViewModel);
        }

        // GET: Calculate/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Calculate/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calculate/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Calculate/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Calculate/Edit/5
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

        // GET: Calculate/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Calculate/Delete/5
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
