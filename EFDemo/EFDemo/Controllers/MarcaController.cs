﻿using EFDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDemo.Controllers{
    public class MarcaController : Controller{
        // GET: Marca
        public ActionResult Index(){
            return View();
        }

        // GET: Marca/Details/5
        public ActionResult Details(int id){
            return View();
        }

  

        // GET: Marca/Create
        public ActionResult Create(){
            return View();
        }

        // POST: Marca/Create
        [HttpPost]
        public ActionResult Create(MarcaModelo marca){
            try{
                using (var bd = new Contexto()){
                    bd.Marcas.Add(marca);
                    bd.SaveChanges();
                }

                return RedirectToAction("Index", "Vehiculo");
            }
            catch {
                return View("Index");
            }
        }

        // GET: Marca/Edit/5
        public ActionResult Edit(int id){
            return View();
        }

        // POST: Marca/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection){
            try{
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch{
                return View();
            }
        }

        // GET: Marca/Delete/5
        public ActionResult Delete(int id){
            return View();
        }

        // POST: Marca/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection){
            try{
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch{
                return View();
            }
        }
    }
}
