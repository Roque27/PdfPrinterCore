﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class MainGridController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}