using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void CreateInstance_CreateInstanceOfOrder_Order()
    {
      Order orderInstance = new Order();
      Assert.AreEqual(typeof(Order), orderInstance.GetType());
    }
    
    [TestMethod]
    public void GetTotal_AddTwoSubTotals_Total()
    {
      // Add two subtotal values
      int breadSubTotal = 5;
      int pastrySubTotal = 10;
      Assert.AreEqual(15, Order.GetTotal(breadSubTotal,pastrySubTotal));
    }

    [TestMethod]
    public void ApplyDiscount_FiveOffOrdersOverTwentyFive_Total()
    {
      //Arrange
      int breadSubTotal = 15;
      int pastrySubTotal = 15;
      //Act
      //Assert
      Assert.AreEqual(25, Order.GetTotal(breadSubTotal,pastrySubTotal));
    }
  }

}