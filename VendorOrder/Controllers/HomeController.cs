using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace VendorOrder.Solution.Controllers
{
    public class HomeController : Controller
    {   
        [Route("/")]
        public ActionResult Home() { return View(); }
    }
}
