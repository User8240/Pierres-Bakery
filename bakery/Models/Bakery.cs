using System;
//This stuff is basically Business Logic
namespace Bakery.Models
{
  public class Bakery
  {
    private string Bread;
    private string Pastries;

    public Bakery(string Bread, string Pastries)
    {
      Bread = bread;
      Pastries = pastries;
    }

    public bool SelectionBread(string selectBread)
    {
      return (Bread == selectBread);
    }

    public bool SelectionPastry(string selectPastry)
    {
      return (Pastries == selectPastry);
    }
  }
}