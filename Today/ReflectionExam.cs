using System;
using System.Reflection;

namespace ConsoleApp8
{
  internal class Program
  {
    const float pi = 3.172f;
    private int a = 10;
    readonly string str = "Harshal Raverkar";
    static int t = 10;

    public Program()
    {
      a = 25;
      str = "Mr. Raverkar";
      t = 100;
      
      Console.WriteLine("My Name is : " + str + " and age is " + a );
      Console.WriteLine("I can change the value of static varibale in non static class " + t);
    }

    static void Main(string[] args)
    {
      var p = new Program();
      var tmp = pi;
      t = 200;
      Console.WriteLine("Again i can change the value of static varibale in Main class " + t);
      Console.WriteLine("The value of tmp is " + tmp);


      var test = new TestClass();

      Type type = typeof(TestClass);

      MethodInfo methodInfo = type.GetMethod("Test", BindingFlags.NonPublic | BindingFlags.Instance);
      var result = methodInfo.Name;

      var membrType = type.GetField("temp");
      Console.WriteLine("The private memberType name is " + membrType);
      Console.WriteLine("The private method name is " + result);
    }
  }

  class TestClass
  {
    private void Test()
    {
      int temp = 100000;
      Console.WriteLine("This is private class no buddy can access me ");
    }
  }
}
