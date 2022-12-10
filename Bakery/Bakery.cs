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

      // Prompt for type of order

      // Initialize variables
      string breadType = "";
      string pastryType = "";
      int breadQty = 0;
      int pastryQty = 0;

      Console.WriteLine("Would you like to order bread? (y/n)");
      string wantsToOrder = Console.ReadLine();
      wantsToOrder = wantsToOrder.ToUpper();
      if (wantsToOrder == "Y")
      {
        // Get Bread Order
        Console.WriteLine($"What kind of bread would you like to order?");
        foreach (string type in Bread.BreadTypes)
        {
          Console.WriteLine(type);
        }
      
        // Validate type input
        breadType = Console.ReadLine();
        // string[] breadOptions = 
        breadType = ValidateType(breadType, Bread.BreadTypes);
        Console.WriteLine($"How many loaves of {breadType} bread?");
        string breadOrder = Console.ReadLine();
        // Validate qty input & convert to int
        breadQty = HandleOrderQty(breadOrder);
      }

      // Prompt for type of order
      Console.WriteLine("Would you like to order from our pastry section? (y/n)");
      wantsToOrder = Console.ReadLine();
      wantsToOrder = wantsToOrder.ToUpper();
      if (wantsToOrder == "Y")
      {
        // Get Pastry Order
        Console.WriteLine("What kind of pastry would you like to order?");
        foreach (string type in Pastry.PastryTypes)
        {
          Console.WriteLine(type);
        }
        // Validate type input
        pastryType = Console.ReadLine();
        pastryType = ValidateType(pastryType, Pastry.PastryTypes);
        Console.WriteLine($"How many {pastryType}s?");
        string pastryOrder = Console.ReadLine();
        // Validate qty input & convert to int
        pastryQty = HandleOrderQty(pastryOrder);
      }

      // Get Total
      Bread bread = new Bread(breadQty);
      Pastry pastry = new Pastry(pastryQty);
      int total = Order.GetTotal(bread.SubTotal(), pastry.SubTotal());
      Console.WriteLine($"Thanks for your order of {breadQty} loaves of bread and {pastryQty} pastry items! Your total is ${total}.");
    }

    private static string ValidateType(string typeInput, string[] typeArray)
    {
      string checkType = typeInput.ToLower();
      // While input type not in type array
      while (!Array.Exists(typeArray, element => element == checkType))
      {
        Console.WriteLine($"Please enter a valid type.");
        typeInput = Console.ReadLine();
        checkType = typeInput.ToLower();
      }
      return checkType;
    }

    private static int HandleOrderQty (string order)
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