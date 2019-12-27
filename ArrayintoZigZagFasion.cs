using System;

namespace ConsoleApp14
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var arr = new int[] { 4, 3, 7, 8, 6, 2, 1 };
      var t = zigZag(arr);
      foreach(var a in t)
      {
        Console.WriteLine(a);
      }
    }

    private static int[] zigZag(int[] arr)
    {
      bool flag = true;
      for (int i = 0; i <= arr.Length - 2; i++)
      {
        int temp;
        if (flag)
        {
          if (arr[i] > arr[i + 1])
          {
            temp = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = temp;
          }
        }
        else
        {
          if (arr[i] < arr[i + 1])
          {
            temp = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = temp;
          }
        }
        flag = !flag;
      }
      return arr;
    }
  }
}
