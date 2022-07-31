using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Solution.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet("/vendor/{vendorId}/order/new")]
        public ActionResult New(int vendorId)
        {
            Vendor findVendor = Vendor.Find(vendorId);
            return View(findVendor);
        }
        [HttpGet("/vendor/{vendorId}/order/{orderId}")]
        public ActionResult Show(int vendorId, int orderId)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor findVendor = Vendor.Find(vendorId);
            Order findOrder = findVendor.VendorOrders[orderId];
            model.Add("vendor", findVendor);
            model.Add("order", findOrder);
            return View(model);
        }
    }
}
