using System.Collections.Generic;
using System;

namespace PierresVendors.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }

    public List<Order> Orders { get; set; }
    public int Id { get; set; }
    public static List<Vendor> VendorList = new List<Vendor> { };

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      VendorList.Add(this);
      Id = VendorList.Count;

    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
    public static List<Vendor> GetAll()
    {
      return VendorList;
    }

    public static Vendor Find(int searchId)
    {
      return VendorList[searchId - 1];
    }

  }
}