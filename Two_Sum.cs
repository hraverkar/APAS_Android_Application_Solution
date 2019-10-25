/*
Given an array of integers, return indices of the two numbers such that they add up to a specific target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
Example:
Given nums = [2, 7, 11, 15], target = 9,
Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
*/

using System;

namespace ConsoleApp161
{
  internal static class Program
  {
    private static void Main()
    {
      int[] arr = {2, 7, 11, 15};
      int k = 26;
      var t =FindIndices(arr,k);
      Console.Out.WriteLine(t);
    }

    private static string FindIndices(int[] arr, int k)
    {
      for (var i = 0; i < arr.Length; i++)
      {
        for (var j = i + 1; j < arr.Length; j++)
        {
          if (arr[i] + arr[j] == k)
          {
            int t = Array.IndexOf(arr, arr[i]);
            int p = Array.IndexOf(arr, arr[j]);
            Console.WriteLine(t+" :: "+p);
            return "True";
          }
        }
      }
      return "False";
    }
  }
}
