using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class AakashController : Controller
    {
        public IActionResult Text()
        {
            return Content("Text Page");
        }
    
        public IActionResult JSON()
        {
            return  Json(new {name="aaksh", quote="Akash is the best"});
        }
    
        public IActionResult HTML()
        {
            var h = "<!DOCTYPE html><html><body>abcdefgh" + 
            "<br><br> <a href='/Quote'>Go Back</a></body></html>";
            return Content(h, "text/html");
        }

        public IActionResult View()
        {
            
            return View();
        }
    }
}