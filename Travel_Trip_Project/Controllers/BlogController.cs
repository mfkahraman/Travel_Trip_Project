﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Siniflar;

namespace Travel_Trip_Project.Controllers
{
    public class BlogController : Controller
    {
        private readonly Context db = new Context();
        private readonly BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            by.Blogs = db.Blogs.ToList();
            ViewBag.LastBlogs = db.Blogs.OrderByDescending(x=> x.ID).Take(5).ToList();
            return View(by);
        }


        [HttpGet]
        public ActionResult BlogDetail(int id)
        { 
            by.Blogs = db.Blogs.Where(x=> x.ID == id).ToList();
            by.Comments = db.Comments.Where(x=> x.BlogId == id).ToList();
            return View(by);
        }

        [HttpPost]
        public ActionResult BlogDetail(Comment entity)
        {
            db.Comments.Add(entity);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}