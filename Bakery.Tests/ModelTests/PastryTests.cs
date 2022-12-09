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
  }
}