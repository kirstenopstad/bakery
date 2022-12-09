namespace Bakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }
    private int _price = 2;

    // Constructor
    public Pastry(int qty)
    {
      Quantity = qty;
    }

    // GrandTotal Method
    public static int GrandTotal(int subTotal1, int subTotal2)
    {
      int total = 0;
      return total = subTotal1 + subTotal2;
    }

    // SubTotal Method
    public int SubTotal()
    {
      int sub = 0;
      int basePrice = GetBasePrice();
      int discount = GetDiscount();
      return sub = basePrice - discount;
    }

    private int GetBasePrice()
    {
      return Quantity * _price;
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
