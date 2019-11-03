using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
/*
 *  Quick Sort : Quick sort is Divide and Conquer aalgorithem.
 * It picks an element as pivot and partitions the given array around the piked pivot.
 *
 *  Always pick first element as pivot.
 *  Always pick last element as Pivot.
 *  Pick a random element as pivot.
 *  Pick median as pivot.
 */
namespace ConsoleApp169
{
  internal static class Program
  {
    public static void Main()
    {
      int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
      foreach (var variable in arr)
      {
        Console.Write(variable +" , ");
      }

      Quick_Sort(arr, 0, arr.Length - 1);
      foreach (var variable in arr)
      {
        Console.Write(variable + " , ");
      }
    }

    private static void Quick_Sort(int[] arr, int i, int arrLength)
    {
      if (i < arrLength )
      {
        int pivot = Partition(arr, i, arrLength);

        if (pivot > 1)
        {
          Quick_Sort(arr,i,pivot-1);
        }

        if (pivot+1 < arrLength )
        {
          Quick_Sort(arr,pivot+1,arrLength);
        }
      }
    }

    private static int Partition(int[] arr, int i, int arrLength)
    {
      int pivot = arr[i];
      while (true)
      {
        while (arr[i] < pivot)
        {
          i++;
        }

        while (arr[arrLength] > pivot)
        {
          arrLength--;
        }

        if (i < arrLength)
        {
          if (arr[i] == arr[arrLength]) return arrLength;
          int temp = arr[i];
          arr[i] = arr[arrLength];
          arr[arrLength] = temp;
        }
        else
        {
          return arrLength;
        }
      }
    }
  }
}
