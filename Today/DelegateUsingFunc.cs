using System;

namespace ConsoleApp10
{
  class Program
  {

    public delegate void Print(int value);

    public static void Main(string[] args)
    {
      PrintHelper(PrintMoney, 100);
      PrintHelper(PrintNumbre,10445);
    }

    private static void PrintNumbre(int value)
    {
      Console.WriteLine("Print Number : " +value);
    }

    private static void PrintMoney(int value)
    {
      Console.WriteLine("Print Money : " + value);
    }

    private static void PrintHelper(Print printFunc, int v)
    {
      printFunc(v);
    }
  }
}
