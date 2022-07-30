using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void MakingTheVendorClass()
    {
      Vendor testVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
  }
}