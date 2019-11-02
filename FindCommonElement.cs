using System;

namespace ConsoleApp168
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr1 = {1, 5};
      int[] arr2 = {3, 4, 5, 5, 10};
      int[] arr3 = {5, 5, 10, 20};

      Console.WriteLine("Common elements are :: ");
      findCommon(arr1, arr2, arr3);
    }

    private static void findCommon(int[] arr1, int[] arr2, int[] arr3)
    {
      int i = 0, j = 0, k = 0;
      while (i<arr1.Length && j < arr2.Length && k <arr3.Length)
      {
        if (arr1[i] == arr2[j] && arr2[j] == arr3[k])
        {
          Console.WriteLine(arr1[i] + " ");
          i++;
          j++;
          k++;
        }
        else if(arr1[i] < arr2[j])
        {
          i++;
        }
        else if (arr2[j] < arr3[k])
        {
          j++;
        }
        else
        {
          k++;
        }
      }
    }
  }
}
