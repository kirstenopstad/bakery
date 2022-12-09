using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void CreateInstance_CreateInstanceOfPastry_Pastry()
    {
      Pastry pastryInstance = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), pastryInstance.GetType());
    }

    [TestMethod]
    public void GetQuantity_SetPastryQuantity_Quantity()
    {
      Pastry pastryInstance = new Pastry(1);
      Assert.AreEqual(1, pastryInstance.Quantity);
    }

    [TestMethod]
    public void GetSubtotal_GetPriceForOne_Price()
    {
      // Based on unit price ($2 per pastry) stored in object & qty
      Pastry pastryInstance = new Pastry(1);
      Assert.AreEqual(2, pastryInstance.SubTotal());
    }

    [TestMethod]
    public void GetSubtotal_GetPriceForTwo_Price()
    {
      // Based on unit price ($2 per pastry) stored in object & qty
      Pastry pastryInstance = new Pastry(2);
      Assert.AreEqual(4, pastryInstance.SubTotal());
    }

    [TestMethod]
    public void GetSubtotal_GetPriceForThree_Price()
    {
      // Based on unit price ($2 per pastry) stored in object & qty
      Pastry pastryInstance = new Pastry(3);
      Assert.AreEqual(5, pastryInstance.SubTotal());
    }

    [TestMethod]
    public void GetSubtotal_GetPriceForFour_Price()
    {
      // Based on unit price ($2 per pastry) stored in object & qty
      Pastry pastryInstance = new Pastry(4);
      Assert.AreEqual(7, pastryInstance.SubTotal());
    }

    [TestMethod]
    public void GetSubtotal_GetPriceForFive_Price()
    {
      // Based on unit price ($2 per pastry) stored in object & qty
      Pastry pastryInstance = new Pastry(5);
      Assert.AreEqual(9, pastryInstance.SubTotal());
    }

    [TestMethod]
    public void GetSubtotal_GetPriceForSix_Price()
    {
      // Based on unit price ($2 per pastry) stored in object & qty
      Pastry pastryInstance = new Pastry(6);
      Assert.AreEqual(10, pastryInstance.SubTotal());
    }

  }
}