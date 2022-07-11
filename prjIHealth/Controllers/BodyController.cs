using Microsoft.AspNetCore.Mvc;
using prjiHealth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjiHealth.Controllers
{
    public class BodyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
