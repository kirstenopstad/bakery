using System;

namespace Bakery.Models
{
  public abstract class Item
  {
    // Properties
    public int Quantity { get; set; }
    public int Price { get; set; }
    
    // Methods
    public int GetBasePrice()
    {
      return Quantity * Price;
    }
  }
}