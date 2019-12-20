using System;

namespace ConsoleApp11
{
  public sealed class SingletonClass
  {
    public static readonly object _lock = new object();
    private static SingletonClass _instance = null;
    private SingletonClass()
    {

    }

    public static SingletonClass singletonClass
    {
      get
      {
        lock (_lock)
        {

          if (_instance == null)
          {
            _instance = new SingletonClass();
          }
          return _instance;
        }
      }
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");


    }
  }
}
