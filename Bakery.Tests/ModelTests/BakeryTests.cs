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
//divide -------------------------------------------------
    [TestMethod]
    public void PastryCost_CostOnePastry_Int()
    {
      //Arrange 
      int pastryQuantity = 1;
      double pastryCost = 2;
      //Act
      Pastry pastryOrder = new Pastry(pastryQuantity);
      //Assert
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }
    [TestMethod]
    public void PastryCost_CostTwoPastries_Int()
    {
      //Arrange 
      int pastryQuantity = 2;
      double pastryCost = 4;
      //Act
      Pastry pastryOrder = new Pastry(pastryQuantity);
      //Assert
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }
    [TestMethod]
    public void PastryCost_CostThreePastries_Int()
    {
      //Arrange 
      int pastryQuantity = 3;
      double pastryCost = 5;
      //Act
      Pastry pastryOrder = new Pastry(pastryQuantity);
      //Assert
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }
  }
}