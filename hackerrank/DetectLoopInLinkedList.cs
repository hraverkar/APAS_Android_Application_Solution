using System;
using System.Collections.Generic;

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
  class LinkedList
  {
    public Node head;

    public void push(int d)
    {
      var n_node = new Node(d);
      n_node.next = head;
      head = n_node;
    }

    public bool detectLoop(Node n)
    {
      HashSet<Node> s = new HashSet<Node>();
      while(n != null)
      {
        if (s.Contains(n))
          return true;
        s.Add(n);
        n = n.next;
      }
      return false;
    }
  }

  public class Program
  {
    public static void Main()
    {
      LinkedList list = new LinkedList();
      list.push(20);
      list.push(4);
      list.push(15);
      list.push(10);


      list.head.next = list.head;

      if (list.detectLoop(list.head))
        Console.WriteLine("Loop Found");
      else
        Console.WriteLine("Loop not found");
    }
  }
}
