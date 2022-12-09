using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class Bread
  {
    [TestMethod]
    public void CreateInstance_CreateInstanceOfBread_Bread()
    {
      Bread breadInstance = new Bread();
      Assert.AreEqual(typeof(Bread), breadInstance.GetType());
    }

    [TestMethod]
    public void GetQuantity_SetBreadQuantity_Quantity()
    {
      // Take qty as input and stores in property
      Bread breadInstance = new Bread(2);
      AssertAre.AreEqual(2, breadInstance.Quantity);
    }

  }
}