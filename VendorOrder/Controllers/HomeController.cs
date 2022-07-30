using Microsoft.AspNetCore.Mvc;

namespace VendorOrder.Solution.Controllers
{
    public class HomeController : Controller
    {   
        [Route("/")]
        public ActionResult Home() { return View(); }
    }
}
