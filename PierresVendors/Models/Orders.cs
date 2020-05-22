using System.Collections.Generic;
using System;

namespace PierresVendors.Models
{
  public class Order
  {
    public string Title { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Id { get; set; }

    private static List<Order> orderList = new List<Order> { };

    public Order(string title, DateTime date, string description, decimal price)
    {
      Title = title;
      Date = date;
      Description = description;
      Price = price;
      orderList.Add(this);
      Id = orderList.Count;

    }
    public static List<Order> GetAll()
    {
      return orderList;
    }
    public static Order Find(int searchId)
    {
      return orderList[searchId - 1];
    }
  }
}