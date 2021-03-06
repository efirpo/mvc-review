using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using PierresVendors.Models;

namespace PierresVendors.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

  }
}