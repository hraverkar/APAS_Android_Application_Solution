 using System;

namespace ConsoleApp5
{
  class Program
  {
    static void Main(string[] args)
    {
      int a = 10;
      int b = 20;
      int add = 0;
      int multiple = 0;
      Add_multipleReturn(a,b,ref add ,ref multiple);
      Console.WriteLine(add);
      Console.WriteLine(multiple);
    }

    private static void Add_multipleReturn(int a, int b, ref int add, ref int multiple)
    {
      add = a + b;
      multiple = a * b;
    }
  }
}
