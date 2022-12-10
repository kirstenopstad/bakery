using System;

namespace Bakery.Models
{
  public class Order
  {
    // GrandTotal Method
    public static int GetTotal(int subTotal1, int subTotal2)
    {
      int total = 0;
      total = subTotal1 + subTotal2;
      total = total - GetOrderDiscount(total);
      return total;
    }

    // Discount Code
    private static int GetOrderDiscount(int total)
    {
      int discount = 0;
      if (total > 25)
      {
        discount = 5;
      }
      return discount;
    }
    
  }
}