using System;
using System.Collections;

namespace ConsoleApp144
{
  public class MyStack
  {
    private readonly Stack _stack;
    private int _minElement;

    public MyStack()
    {
      _stack = new Stack();
    }


    public void GetMin()
    {
      if (_stack.Count == 0)
      {
        Console.WriteLine("Stack is empty");
      }
      else
      {
        Console.WriteLine("Minimum element in stack is " + _minElement);
      }
    }

    public void Peek()
    {
      if (_stack.Count == 0)
      {
        Console.WriteLine("Stack is empty");
        return;
      }

      var t = (int) _stack.Peek();
      Console.WriteLine("Top most element is : ");
      if (t < _minElement)
        Console.WriteLine(_minElement);
      else
        Console.WriteLine(t);
    }

    public void Pop()
    {
      if (_stack.Count == 0)
      {
        Console.WriteLine("Stack is empty");
        return;
      }
      Console.Write("Top Most element removed : ");
      var t = (int) _stack.Pop();
      if (t < _minElement)
      {
        Console.WriteLine(_minElement);
        _minElement = 2 * _minElement - t;
      }
      else
      {
        Console.WriteLine(t);
      }

    }

    public void Push(int x)
    {
      if (_stack.Count == 0)
      {
        _minElement = x;
        _stack.Push(x);
        Console.WriteLine("Number inserted : " +x);
        return;
      }

      if (x < _minElement)
      {
        _stack.Push(2 * x - _minElement);
        _minElement = x;
      }
      else
      {
        _stack.Push(x);
      }
      Console.WriteLine("Number inserted is  " +x);
    }

  }

  static class Program
  {
    private static void Main()
    {
      var myStack = new MyStack();
      myStack.Push(3);
      myStack.Push(5);
      myStack.Push(36);
      myStack.Push(2);
      myStack.Push(6);
      myStack.Push(8);
      myStack.Push(1);
      myStack.GetMin();
      myStack.Pop();
      myStack.Peek();

    }
  }
}
