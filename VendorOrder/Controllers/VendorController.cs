using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System.Collections.Generic;
using System;


namespace VendorOrder.Solution.Controllers
{
    public class VendorController : Controller
    {
        [HttpGet("/vendor")]
        public ActionResult Index()
        {
            List<Vendor> listVendors = Vendor.GetAll();
            return View(listVendors);
        }
        [HttpPost("/vendor")]
        public ActionResult Create(string vendorName, string description)
        {
            Vendor newVendor = new Vendor(vendorName, description);
            return RedirectToAction("Index");
        }
        [HttpGet("/vendor/new")]
        public ActionResult New() { return View(); }
    }
}
