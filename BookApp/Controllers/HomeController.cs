﻿using Microsoft.AspNetCore.Mvc;

namespace BookApp.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
        public ViewResult ContactUsMain()
        {
            return View();
        }
    }
}
