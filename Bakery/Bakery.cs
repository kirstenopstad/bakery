using System;
using Bakery.Models;

namespace Bakery 
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("===== Menu ======");
      Console.WriteLine("Bread $5 per loaf");
      Console.WriteLine("Pastries $2 per item");
      Console.WriteLine("=== Today's Deals ===");
      Console.WriteLine("Bread: Buy three, get one free!");
      Console.WriteLine("Pastries: Buy more, save more! 3 for $5 and 6 for $10");
      Console.WriteLine("Would you like to place an order? (y/n)");
      string wantsToOrder = Console.ReadLine();
      wantsToOrder = wantsToOrder.ToUpper();
      if (wantsToOrder == "Y")
      {
        // Get Bread Order
        Console.WriteLine("How many loaves of bread?");
        string breadOrder = Console.ReadLine();
        // Validate input & convert to int
        int breadQty = HandleOrder(breadOrder);
        // Get Pastry Order
        Console.WriteLine("How many pastries?");
        string pastryOrder = Console.ReadLine();
        // Validate input & convert to int
        int pastryQty = HandleOrder(pastryOrder);
        // Get Total
        Bread bread = new Bread(breadQty);
        Pastry pastry = new Pastry(pastryQty);
        int total = Pastry.GrandTotal(bread.SubTotal(), pastry.SubTotal());
        Console.WriteLine($"Thanks for your order of {breadQty} loaves of bread and {pastryQty} pastries! Your total is ${total}.");
      }
    }

    private static int HandleOrder(string order)
    {
      // While input is invalid
      while (!IsNumber(order))
      {
        Console.WriteLine("Please enter a valid number.");
        order = Console.ReadLine();
      }
    
      // Convert order input to int
      int orderQty = int.Parse(order);

      // Return order quantity
      return orderQty;
    }

    private static bool IsNumber(string userInput)
    {
      try
      {
        int.Parse(userInput);
        return true;
      }
      catch
      {
        return false;
      }
      
    }
  }
}