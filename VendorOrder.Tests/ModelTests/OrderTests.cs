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
      Order testOrder = new Order("a", "b", "c", "d");
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
    [TestMethod]
    public void TestingTheOrderTitle()
    {
      Order testOrder = new Order("a", "b", "c", "d");
      Assert.AreEqual("a", testOrder.OrderTitle);
    }
    [TestMethod]
    public void TestingTheOrderDescription()
    {
      Order testOrder = new Order("a", "b", "c", "d");
      Assert.AreEqual("b", testOrder.OrderDescription);
    }
    [TestMethod]
    public void TestingTheOrderDate()
    {
      Order testOrder = new Order("a", "b", "c", "d");
      Assert.AreEqual("c", testOrder.OrderDate);
    }
    [TestMethod]
    public void TestingTheOrderPrice()
    {
      Order testOrder = new Order("a", "b", "c", "d");
      Assert.AreEqual("d", testOrder.OrderPrice);
    }
  }
}