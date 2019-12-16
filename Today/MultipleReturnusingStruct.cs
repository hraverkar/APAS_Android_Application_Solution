 using System;

namespace ConsoleApp5
{

  struct Result
  {
    public int add;
    public int multiply;
  }
  class Program
  {
    public static void Main()
    {
      int a = 10;
      int b = 20;
      var result = add_multipleResult(a, b);
      Console.WriteLine(result.add);
      Console.WriteLine(result.multiply);

    }

    private static Result add_multipleResult(int a, int b)
    {
      var result = new Result
      {
        add = a + b,
        multiply = a * b
      };
      return result;
    }
  }
}
