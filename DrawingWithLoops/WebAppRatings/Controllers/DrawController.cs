﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppRatings.Controllers
{
    public class DrawController : Controller
    {
        // GET: Draw
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DrawRating(int rating)
        {
          
            var fullStars = rating * 10 / 100;
            var emptyStars = (100 - rating) * 10 / 100;
            var halfStars = 10 - fullStars - emptyStars;
            var stars = "";
            for (int i = 0; i < fullStars; i++)
            {
                stars += "<img src='/images/full-star.png'/>";
            }
            for (int i = 0; i < halfStars; i++)
            {
                stars += "<img src='/images/half-star.png'/>";
            }
            for (int i = 0; i < emptyStars; i++)
            {
                stars += "<img src='/images/empty-star.png'/>";
            }
            
            ViewBag.Stars = stars;
            ViewBag.Rating = rating;
            return View("Index");
        }
    }
}