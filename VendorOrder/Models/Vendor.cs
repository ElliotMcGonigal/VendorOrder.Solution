using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Models
{
  public class Vendor
  {
    public string VendorName {get; set;}
    public string VendorDescription {get; set;}
    public int Id {get;}
    public List<Order> VendorOrders {get; set;}
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor (string vendorName, string vendorDescription)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
      _instances.Add(this);
      Id = _instances.Count;
      VendorOrders = new List<Order>{};
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    public void AddOrder(Order newOrder)
    {
      VendorOrders.Add(newOrder);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}