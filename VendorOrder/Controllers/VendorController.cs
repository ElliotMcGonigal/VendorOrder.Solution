using Microsoft.AspNetCore.Mvc;

namespace VendorOrder.Solution.Controllers
{
    public class VendorController : Controller
    {
        [Route("/vendor")]
        public ActionResult Vendor() { return View(); }
    }
}
