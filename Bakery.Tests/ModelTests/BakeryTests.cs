using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Test
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadCost_CostOneLoaf_Int()
    {
      //Arrange 
      int breadQuantity = 1;
      double breadCost = 5;
      //Act
      Bread breadOrder = new Bread(breadQuantity);
      //Assert
      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }
    [TestMethod]
    public void BreadCost_CostTwoLoaves_Int()
    {
      //Arrange 
      int breadQuantity = 2;
      double breadCost = 10;
      //Act
      Bread breadOrder = new Bread(breadQuantity);
      //Assert
      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }
    [TestMethod]
    public void BreadCost_CostThreeLoaves_Int()
    {
      //Arrange 
      int breadQuantity = 3;
      double breadCost = 10;
      //Act
      Bread breadOrder = new Bread(breadQuantity);
      //Assert
      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }
  }
}