using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PierreVendor.Models;
using System;

namespace PierreVendor.Controllers
{
    public class VendorController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> vendorList = Vendor.GetAll();
            return View();
        }

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }
        [HttpPost("/vendors")]
        public ActionResult Create (string vendorName, string vendorDescription)
        {
            Vendor newVendor = new Vendor(vendorName, vendorDescription);
            return RedirectToAction("Index");
        }

        [HttpPost()]
        public ActionResult DeleteAllVendors()
        {
            Vendor.ClearAll();
            return RedirectToAction("Index");
        }
    }
}
