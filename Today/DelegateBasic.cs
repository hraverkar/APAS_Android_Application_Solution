using System;

namespace ConsoleApp10
{
  public delegate int NumberChanger(int n);
  public class TestDelegate
  {
    static int num = 10;
    public int Addnumber(int p)
    {
      num += p;
      return num;
    }

    public int Multiplynumber(int p)
    {
      num *= p;
      return num;
    }

    public int GetNumber()
    {
      return num;
    }
  }


  class Program
  {
    public static void Main()
    {
      var test = new TestDelegate();
      var nm1 = new NumberChanger(test.Addnumber);
      var nm2 = new NumberChanger(test.Multiplynumber);
      nm1(25);
      Console.WriteLine("Addition :: " + test.GetNumber());
      nm2(5);
      Console.WriteLine("Multiplication :: " + test.GetNumber());
    }
  }
}
