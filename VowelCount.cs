using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp64
{
  class Program
  {
    static void Main(string[] args)
    {

      string str = "HElloHarshalRaverkar";
      var t = Regex.Matches(str, @"[aeiouAEIOU]").Count;
      Console.WriteLine(t);

      CountVowel(str);
    }

    private static void CountVowel(string str)
    {
      int count = 0;
      var hasset = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
      char[] ch = str.ToLower().ToCharArray();
      for(int i=0;i<ch.Length;i++)
      {
        if(hasset.Contains(ch[i]))
        {
          count++;
        }
      }
      Console.WriteLine(count);
    }
  }
}
