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
        Console.WriteLine("How many loaves of bread? (press Enter for none)");
        string breadOrder = Console.ReadLine();
        if (!IsNumber(breadOrder))
        {
          Console.WriteLine("Please enter a valid number.");
        } 
        // Get Pastry Order
        Console.WriteLine("How many pastries? (press Enter for none)");
        string pastryOrder = Console.ReadLine();
        // Handle user entering nothing
        if  (breadOrder == "" && pastryOrder == "")
        {
          Console.WriteLine("Changed your mind! No order, gotcha.");
          return;
        } 
        else if (pastryOrder == "")
        {
          Console.WriteLine("No pastry order, gotcha.");
          return;
        } 
        else if (breadOrder == "")
        {
          Console.WriteLine("No bread order, gotcha.");
          return;
        }
        // Validate input
        int breadQty = int.Parse(breadOrder);
        int pastryQty = int.Parse(pastryOrder);
        // Get Total
        Bread bread = new Bread(breadQty);
        Pastry pastry = new Pastry(pastryQty);
        int total = Pastry.GrandTotal(bread.SubTotal(), pastry.SubTotal());
        Console.WriteLine($"Thanks for your order of {breadQty} loaves of bread and {pastryQty} pastries! Your total is ${total}.");
      }
    }

    private static bool IsNumber(string userInput)
    {
      try
      {
        int.Parse(userInput);
      }
      catch
      {
        Console.WriteLine("Changed your mind! No order, gotcha.");
        throw;
      }
      return true;
    }
  }
}