using System;
using System.Threading;

namespace ConsoleApp7
{
  class Program
  {
    static void Main(string[] args)
    {
      ThreadStart tdstard = new ThreadStart(threadJob);
      Thread thread = new Thread(tdstard);
      thread.Start();
      for (int i = 0; i <= 8; i++)
      {
        Console.WriteLine("My main therad " + i);
        Thread.Sleep(1000);
      }
    }

    private static void threadJob()
    {
      for (int i = 0; i <= 6; i++)
      {
        Console.WriteLine("This is Thead : : " + i);
        Thread.Sleep(500);
      }
    }
  }
}
