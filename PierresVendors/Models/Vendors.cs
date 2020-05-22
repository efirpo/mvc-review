using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }

    public List<Order> Orders { get; set; }
    public int Id { get; set; }
    public static List<Vendor> VendorList { get; set; }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      VendorList.Add(this);
      Id = VendorList.Count();

    }
  }
}