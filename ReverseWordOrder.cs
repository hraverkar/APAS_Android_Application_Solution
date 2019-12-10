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
        public static void Main(string[] args)
        {
            //Your code goes here
            var str = "Hello Harshal Raverkar";
            var name = new Name();
            var t  = name.ReverseStringOrder(str);
            Console.WriteLine(t);
        }
    }
    
    public class Name{
        
        public string ReverseStringOrder(string str)
        {
            List<string> li = new List<string>();
            var splitWord = str.Split(' ');         
            for(int i = splitWord.Length -1; i >= 0; i--)
            {
                li.Add(splitWord[i]);
            }           
           return string.Join( " ", li);
        }
}
}

        
