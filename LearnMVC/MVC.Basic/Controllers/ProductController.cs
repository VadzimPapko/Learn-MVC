﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Basic.Infrustructure.Filters;
using MVC.Basic.Models;
using MVC.Basic.Repositories;

namespace MVC.Basic.Controllers
{
    //[TypeFilter(typeof(CustomExceptionFilter))]
    //[Route("[controller]/[action]/{id?}")]
    public class ProductController : Controller
    {
        // GET: Product
        //[Route("motorcycles")]
        //[Route("[controller]/motorcycles")]
        public ActionResult Index()
        {
            return View(MotorcycleRepository.Motorcycles);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View(MotorcycleRepository.Motorcycles.FirstOrDefault(_ => _.Id == id));
        }

        /*
        // GET: Product/Details/Test
        public ActionResult Details(string id)
        {
            return View($"id- {id}");
        }
        */

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Motorcycle motorcycle)
        {
            throw new Exception();

            try
            {
                if (!ModelState.IsValid) return View(motorcycle);

                MotorcycleRepository.AddMotorcycle(motorcycle);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}