using System;
using System.Collections.Generic;

namespace ConsoleApp147
{
  internal static class Program
  {
    private static void Main()
    {
      int[] arr = {-2, -3, 4, -1, -2, 1, 5, -3};
      MaxSubArray(arr);

    }

    private static void MaxSubArray(IReadOnlyList<int> arr)
    {
      var len = arr.Count;
      int maxSoFor = int.MinValue, maxEndingHere = 0;
      for (var i = 0; i < len; i++)
      {
        maxEndingHere = maxEndingHere + arr[i];
        if (maxSoFor < maxEndingHere)
        {
          maxSoFor = maxEndingHere;
        }

        if (maxEndingHere < 0)
        {
          maxEndingHere = 0;
        }
      }
      Console.WriteLine(maxSoFor);
    }
  }
}
