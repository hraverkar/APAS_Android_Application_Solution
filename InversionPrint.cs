using System;

namespace ConsoleApp13
{
  class Program
  {
    static int[] arr = new int[] { 1, 20, 6, 4, 5 };
    static void Main()
    {
      Console.WriteLine(" the inversion number count :: " + getInvCount(arr.Length));
    }

    private static int getInvCount(int length)
    {
      int inv_count = 0;
      for(int i=0;i<length -1;i++)
      {
        for(int j=i+1;j<length;j++)
        {
          if(arr[i] > arr[j])
          {
            inv_count++;
          }
        }
      }
      return inv_count;
    }
  }
}
