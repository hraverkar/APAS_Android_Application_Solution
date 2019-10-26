using System;

namespace ConsoleApp162
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = 19;
      var t = isPrime(n);
      Console.WriteLine(t);
    }

    private static bool isPrime(int n)
    {
      for (int i = 2; i*i <=n ; i++)
      {
        if (n%i == 0)
        {
          return false;
        }
      }
      return true;
    }
  }
}
