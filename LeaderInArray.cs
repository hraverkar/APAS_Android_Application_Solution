using System;

namespace ConsoleApp13
{
  class Program
  {
    static void Main()
    {
      int[] arr = new int[] { 16, 17, 4, 5, 3, 2 };
       printLeader(arr);
    }

    private static void printLeader(int[] arr)
    {
      var length = arr.Length;
      for(int i=0;i<length;i++)
      {
        int j;
        for(j=i+1; j<length; j++)
        {
          if(arr[i] <= arr[j])
          {
            break;
          }
        }
        if(j == length)
        {
          Console.WriteLine(arr[i] + " ");
        }
      }
    }
  }
}
