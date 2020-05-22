using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PierresVendors.Models;

namespace PierresVendors.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    [HttpGet("vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor vendor = Vendor.Find(id);
      List<Order> vendorOrders = vendor.Orders;
      model.Add("vendor", vendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, DateTime orderDate, string orderDescription, decimal orderPrice)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor thisVendor = Vendor.Find(vendorId);
      decimal roundPrice = Math.Round(orderPrice, 2);
      Order newOrder = new Order(orderTitle, orderDate, orderDescription, roundPrice);
      thisVendor.AddOrder(newOrder);
      List<Order> vendorOrders = thisVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", thisVendor);
      return View("Show", model);
    }
  }
}