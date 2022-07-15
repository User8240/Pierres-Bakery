using System;
using System.Collections.Generic;
using Bakery.Models;
//This stuff is basically UI logic
namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      //create bread and pastries instances of their provided class
      Bread bread = new Bread("Bread", 0);
      List<Bread> BreadsList = new List<Bread>() { bread };

      Pastries pastries = new Pastries("Pastry", 0)
      List<Pastries> PastriesList = new List<Pastries>() { pastries };

      Console.WriteLine("Welcome to Pierre's Bakery! Here's our Menu: | Bread - $ | Pastries - $ |");
      Console.WriteLine("Would you like to buy any bread today? (type 'y' or 'n'");
      //Take user input for bread (Y or N) and store in breadYoN variable
      string breadYoN = Console.ReadLine();
      
      List<Bread> UserInputBread = new List<bread>(0);

      foreach (Bread element in ) 
      if 

    }
  }
}