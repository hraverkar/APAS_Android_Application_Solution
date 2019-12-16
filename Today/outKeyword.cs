 using System;

namespace ConsoleApp5
{
  class Program
  {
    static void Main(string[] args)
    {
      int a = 10;
      int b = 20;
      int add ;
      int multiple;
      Add_multipleReturn(a,b,out add ,out multiple);
      Console.WriteLine(add);
      Console.WriteLine(multiple);
    }

    private static void Add_multipleReturn(int a, int b, out int add, out int multiple)
    {
      add = a + b;
      multiple = a * b;
    }
  }
}
