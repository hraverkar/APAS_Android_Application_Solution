//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string [] args)
        {
            var arr = new int[]{1,2,3,4,5};
            int d = 3;
            List<int> list = new List<int>();
            for(int i = d; i < arr.Length; i++)
            {
                list.Add(arr[i]);
            }
                  
            for(int j = 0; j <d; j++)
            {
                list.Add(arr[j]);
            }
        
            foreach(var t in list)
            {
                System.Console.WriteLine(t);
            }
        }
    }
}
