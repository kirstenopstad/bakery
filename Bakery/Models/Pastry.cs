namespace Bakery.Models
{
  public class Pastry : Item
  {
    // Properties
    public static string[] PastryTypes = {"muffin","scone","croissant","cookie"};

    // Constructor
    public Pastry(int qty)
    {
      Quantity = qty;
      Price = 2;
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
      int discount = 0;
      if (Quantity >= 6)
      {
        discount = 2;
      }
      else if (Quantity > 2)
      {
        discount = 1;
      }
      else
      {
        discount = 0;
      }
      return discount;
    }
  }
}
