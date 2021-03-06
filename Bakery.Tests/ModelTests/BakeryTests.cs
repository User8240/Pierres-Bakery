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
      int breadQuantity = 1;
      double breadCost = 5;
      Bread breadOrder = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }
    [TestMethod]
    public void BreadCost_CostTwoLoaves_Int()
    {
      int breadQuantity = 2;
      double breadCost = 10;
      Bread breadOrder = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }
    [TestMethod]
    public void BreadCost_CostThreeLoaves_Int()
    {
      int breadQuantity = 3;
      double breadCost = 10;
      Bread breadOrder = new Bread(breadQuantity);
      Assert.AreEqual(breadCost, breadOrder.BreadCost());
    }
    [TestMethod]
    public void PastryCost_CostOnePastry_Int()
    {
      int pastryQuantity = 1;
      double pastryCost = 2;
      Pastry pastryOrder = new Pastry(pastryQuantity);
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }
    [TestMethod]
    public void PastryCost_CostTwoPastries_Int()
    {
      int pastryQuantity = 2;
      double pastryCost = 4;
      Pastry pastryOrder = new Pastry(pastryQuantity);
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }
    [TestMethod]
    public void PastryCost_CostThreePastries_Int()
    {
      int pastryQuantity = 3;
      double pastryCost = 5;
      Pastry pastryOrder = new Pastry(pastryQuantity);
      Assert.AreEqual(pastryCost, pastryOrder.PastryCost());
    }
  }
}