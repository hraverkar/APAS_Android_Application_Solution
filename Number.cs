using System;

namespace ConsoleApp66
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = 151; // 151 opposite 151
      int k = 153; // 1^3 = 1 + 5^3 = 125 + 3^3 = 27 = 153
      var t = Palindrome(n);
      Console.WriteLine(t);
      var p = Armstrong(k);
      Console.WriteLine(p);

    }

    private static int Armstrong(int k)
    {
      int sum = 0;
      while (k > 0)
      {
        int r = k % 10;
        sum = sum + (r * r * r);
         k = k / 10;
      }
      return sum;
    }

    private static int Palindrome(int n)
    {
      int sum = 0;
      while(n > 0)
      {
        int r = n % 10;
        sum = (sum * 10) + r;
        n /= 10;
      }
      return sum;
    }
  }
}
