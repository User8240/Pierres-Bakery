using System;
using System.Collections.Generic;
using Bakery.Models;

//This stuff is basically UI logic
namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! Here's our Menu: Bread - $" + Bread.Price);
      Console.WriteLine("Would you like to buy any bread today? (Type 'y' or 'n')");
      string response = Console.ReadLine();
        if (response == "y")
        {
            Console.WriteLine("How many loaves would you like? (Enter a Number)");
            int breadOrder = int.Parse(Console.ReadLine());
            Bread usersBreadOrder = new Bread(breadOrder);
            Console.WriteLine("Your Order " + usersBreadOrder.Quantity + " loaf/loaves"); 
            Console.WriteLine("Cost: $" + usersBreadOrder.BreadCost());
        }
        else 
        {
            Console.WriteLine("Thanks user, Come again!");
        }
    }
  }
}