﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {

             return View();
        }
    }
}