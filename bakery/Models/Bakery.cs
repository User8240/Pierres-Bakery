using System;
//This stuff is basically Business Logic
namespace Bakery.Models
{
  public class Bread
  { 
    private static int _Price = 5;
    private int _Deal;
    public int Quantity { get; set; } 

    public static int Price 
    {
      get { return _Price; }
      set { _Price = value; }
    }

    public Bread(int quantity)
    {
      _Price = Price;
      _Deal = 0.5;
      Quantity = quantity;
    }

    public int BreadCost()
    {
      double breadTotal = 0;
      for (int index = 0; index <= Quantity; index++)
      {
        if (index == 0)
        {
          breadTotal += 0;
        }
        else if (index % 3 == 0)
        {
          breadTotal += _Price * _Deal;
        }
        else
        {
          breadTotal += _Price;
        }
        return breadTotal;
      }
    }
  }
}  
