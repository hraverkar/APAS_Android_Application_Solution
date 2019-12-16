 using System;

namespace ConsoleApp5
{
  class Program
  {
    public static void Main()
    {
      int a = 10;
      int b = 20;
      int c = 5;
      float d = 1.2f;

      var test = new Test();
      var p = test.MthodToOverLoading(a, b);
      Console.WriteLine(p);


      var q = test.MthodToOverLoading(a, b, c);
      Console.WriteLine(q);

      var r = test.MthodToOverLoading(d, a);
      Console.WriteLine(r);
    }
  }


  class Test
  {
    public  int MthodToOverLoading(int a, int b)
    {
      return a + b;
    }

    public  int MthodToOverLoading(int a, int b, int c)
    {
      return a + b + c;
    }

    public  int MthodToOverLoading(float d, int a)
    {
      return (int)d + a;
    }
  }
}
