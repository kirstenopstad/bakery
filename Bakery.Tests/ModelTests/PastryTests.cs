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
      Pastry pastryInstance = new Pastry();
      Assert.AreEqual(typeof(Pastry), pastryInstance.GetType());
    }
  }
}