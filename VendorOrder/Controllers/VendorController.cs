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
        [HttpGet("/vendor/{vendorId}")]
        public ActionResult Show(int vendorId)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor findVendor = Vendor.Find(vendorId);
            List<Order> vendorOrder = findVendor.VendorOrders;
            model.Add("vendor", findVendor);
            model.Add("orders", vendorOrder);
            return View(model);
        }
        [HttpPost("/vendor/{vendorId}/order")]
        public ActionResult Create(int vendorId, string orderTitle, string orderDescription, string orderDate, string orderPrice)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor findVendor = Vendor.Find(vendorId);
            Order newOrder = new Order(orderTitle, orderDescription, orderDate, orderPrice);
            findVendor.AddOrder(newOrder);
            List<Order> vendorOrder = findVendor.VendorOrders;
            model.Add("vendor", findVendor);
            model.Add("orders", vendorOrder);
            return View("Show", model);
        }
    }
}
