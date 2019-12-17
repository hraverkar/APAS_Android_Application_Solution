using System;
using System.Threading;

namespace ConsoleApp7
{
  class Program
  {
    static int count = 0;
    static void Main(string[] args)
    {
      ThreadStart threadStart = new ThreadStart(ThreadJob);
      Thread thread = new Thread(threadStart);
      thread.Start();
      for(int i = 1; i <= 10; i++)
      {
        count++;
      }
      thread.Join();
      Console.WriteLine("Final count is : " + count);
    }

    private static void ThreadJob()
    {
     for(int i=11;i<=20;i++)
      {
        count++;
      }
    }
  }
}
