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

        [HttpGet("/categories/new")]
        public ActionResult New()
        {
            return View();
        }
    }
}