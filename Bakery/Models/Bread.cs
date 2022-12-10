using System;
// using System.Collections.Generic;

namespace Bakery.Models
{

  public class Bread : Item
  {
    // Properties
    public static string[] BreadTypes = {"multigrain", "sourdough", "rye", "pumpernickel"};

    // Constructor
    public Bread(int qty)
    {
      Quantity = qty;
      Price = 5;
    }

    // SubTotal Method
    public int SubTotal()
    {
      int sub = 0;
      int basePrice = GetBasePrice();
      int discount = GetDiscount();
      return sub = basePrice - discount;
    }

    private int GetDiscount()
    {
      int thirdLoaves = Quantity / 3;
      int discount = thirdLoaves * Price;
      return discount;
    }
  }
}
