﻿using Microsoft.AspNetCore.Mvc;

namespace EndV.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}