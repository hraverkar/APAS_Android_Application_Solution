 using System;

namespace ConsoleApp5
{
  class Program
  {
    public static void Main()
    {
      int a = 10;
      int b = 20;
      var result = add_multipleResult(a, b);
      Console.WriteLine(result.Item1);
      Console.WriteLine(result.Item2);

    }

    private static Tuple<int , int> add_multipleResult(int a, int b)
    {
      var tuple = new Tuple<int, int>(a + b, a * b);
      return tuple;
    }
  }
}
