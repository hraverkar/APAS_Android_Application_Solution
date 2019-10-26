using System;
using System.Collections.Generic;

namespace ConsoleApp162
{
  internal class Test
  {
    private static int V = 9;

    private int minDistance(IReadOnlyList<int> dist, IReadOnlyList<bool> sptSet)
    {
      int min = int.MaxValue, minIndex = -1;
      for (var v = 0; v < V; v++)
      {
        // ReSharper disable once ComplexConditionExpression
        if (dist == null || (sptSet[v] != false || dist[v] > min)) continue;
        min = dist[v];
        minIndex = v;
      }
      return minIndex;
    }

    private static void PrintSolution(IReadOnlyList<int> dist, int n)
    {
      Console.Write("Vertex Distance ");
      for (var i = 0; i < V; i++)
      {
        Console.Write(i + "\t\t " +dist[i] +"\n");
      }
    }

    internal void dijkstra(int[,] graph, int src)
    {
      var dist = new int[V];
      var sptSet = new bool[V];
      for (var i = 0; i < V; i++)
      {
        dist[i] = int.MaxValue;
        sptSet[i] = false;
      }

      dist[src] = 0;
      for (var i = 0; i <V-1; i++)
      {
        var u = minDistance(dist, sptSet);
        sptSet[u] = true;
        for (var v = 0; v < V; v++)
        {
          if (!sptSet[v] && graph[u,v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u,v] < dist[v])
          {
            dist[v] = dist[u] + graph[u, v];
          }
          
        }
      }
      PrintSolution(dist,V);
    }
  }
  internal static class Program
  {
    public static void Main()
    {

      var graph = new int[,]
      {
        {0, 4, 0, 0, 0, 0, 0, 8, 0},
        {4, 0, 8, 0, 0, 0, 0, 11, 0},
        {0, 8, 0, 7, 0, 4, 0, 0, 2},
        {0, 0, 7, 0, 9, 14, 0, 0, 0},
        {0, 0, 0, 9, 0, 10, 0, 0, 0},
        {0, 0, 4, 14, 10, 0, 2, 0, 0},
        {0, 0, 0, 0, 0, 2, 0, 1, 6},
        {8, 11, 0, 0, 0, 0, 1, 0, 7},
        {0, 0, 2, 0, 0, 0, 6, 7, 0}
      };
      var test = new Test();
      test.dijkstra(graph, 0);
    }
  }
}
