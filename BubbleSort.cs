/*
Bubble Sort is a simple algorithm which is used to sort a given set of n elements 
provided in form of an array with n number of elements. Bubble Sort compares all 
the element one by one and sort them based on their values.


Following are the steps involved in bubble sort(for sorting a given array in ascending order):

* Starting with the first element(index = 0), compare the current element with the next element of the array.
* If the current element is greater than the next element of the array, swap them.
* If the current element is less than the next element, move to the next element. Repeat Step 1.


Hence the time complexity of Bubble Sort is O(n2).
The main advantage of Bubble Sort is the simplicity of the algorithm.
The space complexity for Bubble Sort is O(1), because only a single additional memory space is required i.e. for temp variable.
Also, the best case time complexity will be O(n), it is when the list is already sorted.
Following are the Time and Space complexity for the Bubble Sort algorithm.

Worst Case Time Complexity [ Big-O ]: O(n2)
Best Case Time Complexity [Big-omega]: O(n)
Average Time Complexity [Big-theta]: O(n2)
Space Complexity: O(1)

*/


using System;

namespace ImplementingBubbleSortAlgo
{
  internal static class Program
  {
    private static void Main()
    {
      Console.WriteLine("Please enter the number of element in array");
      var n = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

      //int[] arr = {6, 7, 3, 8, 2, 9, 1};
      var arr = new int[n];
      Console.WriteLine("Please enter the element of array");
      for (var i = 0; i <n; i++)
      {
        arr[i] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
      }
      Console.WriteLine("Sorted Array is :: ");
      BubbleSort(arr);
    }

    private static void BubbleSort(int[] arr)
    {
      int flag;
      for (var i = 0; i < arr.Length; i++)
      {
        for (var j = i; j < arr.Length; j++)
        {
          flag = 0;
          if (arr[j] < arr[i])
          {
            var temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
            // if swapping happens update flag to 1;
            flag = 1;
          }
        }
      }

      foreach (var variable in arr)
      {
        Console.WriteLine(variable);
      }
    }
  }
}
