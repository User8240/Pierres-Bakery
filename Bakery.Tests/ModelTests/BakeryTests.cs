using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Test
{
  [TestClass]
  public class BakeryTest
  {
    [TestMethod]
    public void MethodName_WhatItDo_ToF()
    {
      Class newInstance = new Class ("pass in something");
      Assert.AreEqual(ToF, newInstance.MethodName());
    }
  }
}