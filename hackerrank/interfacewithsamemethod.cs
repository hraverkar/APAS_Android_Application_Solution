

using System;
using System.Collections.Generic;
using System.Linq;

namespace Rextester
{
    interface ITest{
    void Foo();
        void Bar();
    }
    
    
    interface IText{
    void Foo();
        void Bar();
    }
    
    class Proj : ITest, IText
    {
    
        void ITest.Foo()
        {
            Console.WriteLine("Hello I am foo from ITest interface");
        }
        
        void ITest.Bar()
        {
            Console.WriteLine("Hello I am bar from ITest interface");
        }
        
        void IText.Foo()
        {
            Console.WriteLine("Hello I am bar from IText interface");
        }
            
        void IText.Bar()
        {
            Console.WriteLine("Hello I am bar from IText interface");
        }
        
        public void Name()
        {
            Console.WriteLine("Hello my name is Harshal Raverkar");
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            Console.WriteLine("Hello, world!");
            ITest test = new Proj();
            test.Bar();
            
            IText text = new Proj();
            text.Foo();
            
            var pro = new Proj();
            pro.Name();
        }
    }
}
