using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void MakingTheOrderClass()
    {
      Order testOrder = new Order();
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
  }
}