using System;

namespace ConsoleApp11
{
  public interface IMiddeleWare
  {
    void DoAction();
  }

  class MiddleWare1 : IMiddeleWare
  {
    public void DoAction()
    {
      Console.WriteLine("Call from the middelware 1 ");
    }
  }

  class MiddleWare2 : IMiddeleWare
  {
    public void DoAction()
    {
      Console.WriteLine("Its come fomr middelware 2 ");
    }
  }

  public class MiddleFactory
  {
    public IMiddeleWare GetMiddeleWare(int test)
    {
      switch (test)
      {
        case 1: return new MiddleWare1();
        case 2: return new MiddleWare2();
        default: return new MiddleWare1();
      }
    }
  }

  public class Program
  {
    public static void Main()
    {
      MiddleFactory middleFactory = new MiddleFactory();
      IMiddeleWare middeleWare = middleFactory.GetMiddeleWare(1);
      middeleWare.DoAction();
    }
  }
}
