using System;
using System.Diagnostics;

namespace ConsoleApp9
{

  interface ILogger
  {
    void Info(string message);
    void Error(string message);

    void Warm(string message)
    {
      Console.WriteLine(message);
    }
  }

  public class ConsoleLogger : ILogger
  {
    public void Error(string test)
    {
      Console.WriteLine(test);
    }

    public void Info(string text)
    {
      Console.WriteLine(text);
    }
  }



  class Program
  {
    static void Main(string[] args)
    {
      int? test;
      test = 100;
      Console.WriteLine(100);

      ILogger logger = new ConsoleLogger();
      logger.Warm("Hello Harshal Raverkar this is default implementation");
    }
  }
}
