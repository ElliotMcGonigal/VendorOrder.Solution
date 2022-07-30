using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void MakingTheVendorClass()
    {
      Vendor testVendor = new Vendor("a", "b");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
    [TestMethod]
    public void TestingTheVendorName()
    {
      Vendor testVendor = new Vendor("a", "b");
      Assert.AreEqual("a", testVendor.VendorName);
    }
    [TestMethod]
    public void TestingTheVendorDescription()
    {
      Vendor testVendor = new Vendor("a", "b");
      Assert.AreEqual("b", testVendor.VendorDescription);
    }
    [TestMethod]
    public void TestingTheVendorId()
    {
      Vendor testVendor = new Vendor("a", "b");
      Assert.AreEqual(1, testVendor.Id);
    }
    [TestMethod]
    public void TestingTheVendorGetAll()
    {
      Vendor testVendor = new Vendor("a", "b");
      Vendor testVendor2 = new Vendor("c", "d");
      List<Vendor> testList = new List<Vendor> {testVendor, testVendor2};
      CollectionAssert.AreEqual(testList, Vendor.GetAll());
    }
    [TestMethod]
    public void TestingTheVendorFind()
    {
      Vendor testVendor = new Vendor("a", "b");
      Assert.AreEqual(testVendor, Vendor.Find(1));
    }
    [TestMethod]
    public void TestingTheVendorOrderCreator()
    {
      Vendor testVendor = new Vendor("a", "b");
      Order newOrder = new Order("a", "b", "c", "d");
      testVendor.AddOrder(newOrder);
      Assert.AreEqual(newOrder, testVendor.VendorOrders[0]);
    }
  }
}