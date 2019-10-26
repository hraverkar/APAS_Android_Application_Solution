using System;
using System.Collections.Generic;
/*
 *  Insertion Sort : Insertion sort in the similer way as we sort cards in our hand in a card game.
 * We assume that the first card is already sorted then, We select an unsorted card.
 *
 *  Insertion sort : 
 */

namespace ConsoleApp162
{
  internal static class Test
  {
    public static void Main()
    {
      int[] data = {9, 5, 1, 4, 3};
      InsertionSort(data);
    }

    private static void InsertionSort(IList<int> data)
    {
      var len = data.Count;
      for (var i = 0; i < len; i++)
      {
        for (var j = 0; j < len; j++)
        {
          if (data[i] < data[j])
          {
            var temp = data[j];
            data[j] = data[i];
            data[i] = temp;
          }
        }
      }

      foreach (var variable in data)
      {
        Console.WriteLine(variable);
      }
    }
  }
}



