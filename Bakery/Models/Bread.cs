namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }
    private int _price = 5;

    // Constructor
    public Bread(int qty)
    {
      Quantity = qty;
    }

    // SubTotal Method
    public int SubTotal()
    {
      int sub = 0;
      int basePrice = GetBasePrice();
      return sub = basePrice;
    }

    private int GetBasePrice()
    {
      return Quantity * _price;
    }

  }
}
