using System;

namespace ConsoleApp168
{
  internal static class Program
  {
    private static void Main()
    {
      int [] arr = { 2, 4, 6, 8, 6, 2 };
      var x = 6;
      FirstElement(arr, x);
      LastElement(arr, x);
    }

    private static void LastElement(int[] arr,int x)
    {
      var t = Array.LastIndexOf(arr, x);
      Console.WriteLine("Last Index of Array is :: " + t);
    }

    private static void FirstElement(int[] arr, int x)
    {
      var t = Array.IndexOf(arr, x);
      Console.WriteLine("first Index of Array is :: " + t);
    }
  }
}
