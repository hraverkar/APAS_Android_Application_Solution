using System;
using System.Threading;

namespace ConsoleApp7
{
  class Program
  {
    static void Main(string[] args)
    {
      Counter foo = new Counter();
      ThreadStart threadStart = new ThreadStart(foo.CounterNumber);
      Thread t = new Thread(threadStart);
      t.Start();
      for (int i = 13; i < 22 ;i++)
      {
        Console.WriteLine(" This is Comming from Main therad " + i);
        Thread.Sleep(200);
      }

    }
  }

  internal class Counter
  {
    public void CounterNumber()
    {
      for (int i = 0; i <= 12; i++)
      {
        Console.WriteLine("This is the thread comes from class " + i);
        Thread.Sleep(500);
      }
    }
  }
}
