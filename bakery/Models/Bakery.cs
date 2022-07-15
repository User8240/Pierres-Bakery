using System;
//This stuff is basically Business Logic
namespace Bakery.Models
{
  public class Bread
  { //Create & make variables private
    private string _bread;
    private int _price;

    public Bread(string bread, int price)
    {
      _bread = bread;
      _price = price;
    }

    //Get-ting the private variables
    public string GetBread()
    {
      return _bread;
    }

    public int GetPrice()
    {
      return _price;
    }

    //Method for bread selection

    public bool SelectBread(string selectBread)
    {
    return (_bread == selectBread);
    }
  }
//------------------------------------------------------------------
    public class Pastries
  { //Create & make variables private
    private string _pastries;
    private int _price;

    public Pastries(string pastries, int price)
    {
      _pastries = pastries;
      _price = price;
    }

    //Get-ting the private variables
    public string GetPastries()
    {
      return _pastries;
    }

    public int GetPrice()
    {
      return _price;
    }

    //Method for Pastry selection

    public bool SelectPastry(string selectPastry)
    {
      return (_pastries == selectPastry);
    }
  }
}