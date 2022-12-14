using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void CreateInstance_CreateInstanceOfBread_Bread()
    {
      Bread breadInstance = new Bread(0);
      Assert.AreEqual(typeof(Bread), breadInstance.GetType());
    }

    [TestMethod]
    public void GetQuantity_SetBreadQuantity_Quantity()
    {
      // Take qty as input and stores in property
      Bread breadInstance = new Bread(2);
      Assert.AreEqual(2, breadInstance.Quantity);
    }

    [TestMethod]
    public void GetSubtotal_GetPriceForOne_Price()
    {
      // Based on unit price ($5 per loaf) stored in object, calc base price 
      Bread breadInstance = new Bread(1);
      Assert.AreEqual(5, breadInstance.SubTotal());
    }

    [TestMethod]
    public void GetSubtotal_GetPriceForTwo_Price()
    {
      // Based on unit price ($5 per loaf) stored in object, calc base price 
      Bread breadInstance = new Bread(2);
      Assert.AreEqual(10, breadInstance.SubTotal());
    }

    [TestMethod]
    public void GetSubtotal_GetPriceForThree_Price()
    {
      // Every third loaf is free
      Bread breadInstance = new Bread(3);
      Assert.AreEqual(10, breadInstance.SubTotal());
    }

    [TestMethod]
    public void GetSubtotal_GetPriceForQuantititesFourToTen_Price()
    {
      // Every third loaf is free
      int[] quantities = {4,5,6,7,8,9,10};
      int[] totals = {15, 20, 20, 25, 30, 30, 35}; 
      for (int i = 0; i <  quantities.Length; i++)
      {
        Bread breadInstance = new Bread(quantities[i]);
        Assert.AreEqual(totals[i], breadInstance.SubTotal());
      }
    }
  }
}