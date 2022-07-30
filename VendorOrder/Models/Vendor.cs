using System.Collections.Generic;
using System;

namespace VendorOrder.Models
{
  public class Vendor
  {
    public string VendorName {get; set;}
    public string VendorDescription {get; set;}
    public List<Order> VendorOrders {get; set;}
  }
}