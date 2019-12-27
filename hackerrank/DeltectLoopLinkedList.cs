using System;
using System.Collections.Generic;

//  Implementation of Floyd’s Cycle-Finding Algorithm:

namespace ConsoleApp15
{
  public class Node
  {
    public int data;
    public Node next;
    public Node(int d)
    {
      data = d;
      next = null;
    }
  }
  public class LinkedList
  {
    public Node head;
    public void Push(int d)
    {
      var n = new Node(d);
      n.next = head;
      head = n;
    }


    public int detectLoop()
    {
      Node slow_p =head, fast_p = head;
      while(slow_p !=null && fast_p != null && fast_p.next != null)
      {
        slow_p = slow_p.next;
        fast_p = fast_p.next.next;
        if(slow_p == fast_p)
        {
          Console.WriteLine("Found loop");
          return 1;
        }
      }
      return 0;
    }
  }

  public class Program
  {
    public static void Main()
    {
      LinkedList ls = new LinkedList();
      ls.Push(20);
      ls.Push(4);
      ls.Push(15);
      ls.Push(10);

      ls.head.next.next = ls.head.next;
      ls.detectLoop();
    }
  }


}
