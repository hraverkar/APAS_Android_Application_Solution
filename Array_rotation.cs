using System;
using System.Collections.Generic;

namespace ConsoleApp169
{
  internal static class Program
  {
    private static void Main()
    {
      int[] arr = {1, 2, 3, 4, 5, 6, 7};
      var n = arr.Length;
      leftRotate(arr, 2, n);
    }

    private static void leftRotate(int[] arr, int d, in int n)
    {
      var list = new List<int>();
      for (var i = d; i < n; i++)
      {
        list.Add(arr[i]);
      }

      for (var i = 0; i < d; i++)
      {
        list.Add(arr[i]);
      }

      foreach (var variable in list)
      {
        Console.WriteLine(variable);
      }
    }
  }
}
