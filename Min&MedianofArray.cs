using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp145
{
  internal static class Program
  {
    private static void Main()
    {
      int[] arr1 = {1, 12, 15, 26, 38};
      int[] arr2 = {2, 13, 17, 30, 45};
      var len1 = arr1.Length;
      var len2 = arr2.Length;
      FindMedian(arr1, arr2,len1,len2);
    }

    private static void FindMedian(IReadOnlyList<int> arr1, IReadOnlyList<int> arr2, int len1,int len2)
    {

      var arr = new int[len1 + len2];

      for (var i = 0; i < len1; i++)
      {
        arr[i] = arr[i] + arr1[i];
      }

      for (var i = 0; i < len2; i++)
      {
        arr[i + 5] = arr[i + 5] + arr2[i];
      }

      Array.Sort(arr);

      var sum = arr.Sum();

      var min = sum / arr.Length;
      Console.WriteLine("Min of given array is : " + min);

      var median1 = arr[arr.Length / 2];
      var median2 = arr[(arr.Length / 2) - 1];

      var median = (float) (median1 + median2) / 2;

      Console.WriteLine("Median of given array is : " + median);
    }
  }
}
