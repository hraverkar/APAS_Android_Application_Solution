using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp4
{
  class Program
  {
    const string url = @"https://hraverkar.netlify.com";
    static void Main(string[] args)
    {
      DoSynchronousWork();
      var t = DoSomethingAsynchronousWork();
      DoAsynchronousWorkAfterWait();
      t.Wait();
    }

    private static void DoAsynchronousWorkAfterWait()
    {
      Console.WriteLine("7. While waiting for the async task to finish, we can do some unrelated work...");
      for (var i = 0; i <= 5; i++)
      {
        for (var j = i; j <= 5; j++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }
    }

    private static async Task DoSomethingAsynchronousWork()
    {
      Console.WriteLine("2. Got some data from asynchronous class");
      var test = await getAwaitClassExecution();
      Console.WriteLine("4. The awaited task has completed. Let's get the content length...");
      Console.WriteLine("5. The length of http Get for " + url);
      Console.WriteLine($"6. {test.Length} character");
    }

    private static async Task<string> getAwaitClassExecution()
    {
      using var httpClient = new HttpClient();
      Console.WriteLine("3. Awaiting the result of getAwaitClassExecution of Http Client...");
      try
      {
        var result = await httpClient.GetStringAsync(url);
        string checkResult = result.ToString();
        httpClient.Dispose();
        return checkResult;
      }
      catch (Exception ex)
      {
        string checkResult = "Error " + ex.ToString();
        httpClient.Dispose();
        return checkResult;
      }
    }

    private static void DoSynchronousWork()
    {
      Console.WriteLine("1. Doing something synchronous work progress will wait for finish.");
    }
  }
}
