using System;
using System.Collections.Generic;

namespace ConsoleApp143
{
  static class Program
  {
    static void Main()
    {
      int[] arr = {3, 7, 11, 15};
      const int k = 9;
      TwoSum(arr,k);
    }

    private static void TwoSum(IReadOnlyList<int> arr, int k)
    {
      for (var i = 0; i <arr.Count; i++)
      {
        for (var j = i; j < arr.Count; j++)
        {
          if (arr[i] + arr[j] != k) continue;
          Console.WriteLine(arr[i] +" : "+arr[j]);
          break;
        }
      }
    }
  }
}
