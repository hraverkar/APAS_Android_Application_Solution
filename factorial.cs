using System;

namespace ConsoleApp162
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = 10;
      var t = Fectorial(n);
      Console.WriteLine(t);
    }

    private static int Fectorial(int n)
    {
      if (n < 0)
      {
        return -1;
      }
      else if(n == 0)
      {
        return 1;
      }
      else
      {
        return n * Fectorial(n - 1);
      }
    }
  }
}
