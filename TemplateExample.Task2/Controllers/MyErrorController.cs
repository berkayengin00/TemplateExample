﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplateExample.Task2.Controllers
{
    public class MyErrorController : Controller
    {
        // GET: MyError
        public ActionResult Page404()
        {
            return View();
        }
        public ActionResult Page500()
        {
	        return View();
        }
	}
}