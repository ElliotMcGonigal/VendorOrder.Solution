using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace VendorOrder.Solution.Controllers
{
    public class HomeController : Controller
    {   
        [HttpGet("/")]
        public ActionResult Index() { return View(); }
    }
}
