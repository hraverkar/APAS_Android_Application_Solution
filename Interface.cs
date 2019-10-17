using System;

namespace ConsoleApp150
{
  interface ITest
  {
    void Name();
    void Address();
    void Country();
  }

  interface IMatch
  {
    void Name();
    void Address();
    void Country();
  }
  /*
  class Test : ITest
  {
    public void Name()
    {
      Console.WriteLine("Hello Harshal");
    }

    public void Address()
    {
      Console.WriteLine("Khandwa");
    }

    public void Country()
    {
      Console.WriteLine("India");
    }
  }

  class Match : IMatch
  {
    public void Name()
    {
      Console.WriteLine("Harshal Raverkar");
    }

    public void Address()
    {
      Console.WriteLine("Match");
    }

    public void Country()
    {
      Console.WriteLine("SriLanka");
    }
  }*/

   class page : ITest, IMatch
  {
    void IMatch.Name()
    {
      Console.WriteLine("Kela");
    }

    void IMatch.Address()
    {
      Console.WriteLine("India Pak");
    }

    void IMatch.Country()
    {
      Console.WriteLine("Singapore");
    }

    void ITest.Name()
    {
      Console.WriteLine("Keralaa");
    }

    void ITest.Address()
    {
      Console.WriteLine("Asia");
    }

    void ITest.Country()
    {
      Console.WriteLine("Leja");
    }
  }

  static class Program
  {
    public static void Main(string[] args)
    {
      ITest it = new page();
      it.Country();
      it.Address();
      it.Name();


      IMatch mc = new page();
      mc.Country();
      mc.Address();
      mc.Name();
    }
  }
}
