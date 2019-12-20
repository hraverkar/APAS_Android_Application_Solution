using System;

namespace ConsoleApp10
{
  public delegate void Print(int value);
  class Program
  {
    static void Main(string[] args)
    {
      // print number 
      Print print = new Print(PrintNumber);
      print(100);

      // print money 
      print = printMoney;
      print(150);
    }

    private static void printMoney(int money)
    {
      Console.WriteLine("Money: "+ money);
    }

    private static void PrintNumber(int value)
    {
      Console.WriteLine("Number: "+ value);
    }
  }
}
