 using System;
using System.Threading.Tasks;

namespace ConsoleApp5
{
  class Program
  {
    static void Main(string[] args)
    {
      var test = AsyncTask(60);
      sysncTask();
      test.Wait();
      Console.WriteLine("hello " + test);
    }

    private static void sysncTask()
    {
      Console.WriteLine("2. Task from Harshal Raverkar");
      for (int i = 0; i <= 6; i++)
      {
        for (int j = i; j <= 6; j++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }
    }

    private static async Task<float> AsyncTask(float v)
    {
      try
      {
        Console.WriteLine("Started CPU Bound asynchronous task on a background thread");
        Console.WriteLine("1. Hello Harshal Raverkar");
        var t = await Task.Run(() => v * 1.2f);
        Console.WriteLine($"Finished Task. Total of ${v} after tax of 20% is ${t} ");
        return t;
      }
      catch (Exception e)
      {
        e.ToString();
        return 7;
      }
    }
  }
}
