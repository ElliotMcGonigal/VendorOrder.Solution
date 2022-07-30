using System.Collections.Generic;
using System;

namespace VendorOrder.Models
{
  public class Order
  {
    public string OrderTitle {get; set;}
    public string OrderDescription {get; set;}
    public string OrderDate {get; set;}
    public double OrderPrice {get; set;}
  }
}
