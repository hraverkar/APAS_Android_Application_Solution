using System;

namespace ConsoleApp148
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = {16, 17, 4, 3, 5, 2};
      PrintLeaders(arr);
    }

    private static void PrintLeaders(int[] arr)
    {
      var len = arr.Length;
      for (int i = 0; i < len; i++)
      {
        int j;
        for (j = i+1; j <len; j++)
        {
          if (arr[i] <= arr[j])
          {
            break;
          }
        }

        if (j == len)
        {
          Console.WriteLine(arr[i] + " ");
        }
      }
    }
  }
}
