using System.Collections.Generic;
using System;

namespace VendorOrder.Models
{
  public class Order
  {
    public string OrderTitle {get; set;}
    public string OrderDescription {get; set;}
    public string OrderDate {get; set;}
    public string OrderPrice {get; set;}

    public Order (string orderTitle, string OrderDescription, string OrderDate, string OrderPrice)
    {
      OrderTitle = orderTitle;
      OrderDescription = orderDescription;
      OrderDate = orderDate;
      OrderPrice = orderPrice;
    }
  }
}
