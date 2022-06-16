using System;
using System.Collections.ObjectModel;
using System.Linq;
using NUnit.Framework;
using DataLibrary;

namespace DataLibrary.Tests;

public class GraphTests
{
  [SetUp]
  public void Setup()
  {
  }

  [Test]
  public void Create()
  {
    Graph<int> graph1 = new Graph<int>();
    Assert.That(graph1, Is.Not.Null);

    Graph<int> graph2 = new Graph<int>(new int[] { 1, 2, 3 });
    Assert.That(graph2, Is.Not.Null);
    Assert.That(graph2.Nodes.Count(), Is.EqualTo(3));
  }

  [Test]
  public void AddNode()
  {
    Graph<int> graph1 = new Graph<int>();
    graph1.AddNode(1);
    graph1.AddNode(2);
    graph1.AddNode(3);
    Assert.That(graph1.Nodes.Count(), Is.EqualTo(3));
    Assert.That(graph1.ContainsNode(1), Is.True);
    Assert.That(graph1.ContainsNode(2), Is.True);
    Assert.That(graph1.ContainsNode(3), Is.True);
  }

  // [Test]
  // public void RemoveNode()
  // {
  //   Graph<int> graph1 = new Graph<int>();
  //   GraphNode<int> node1 = new GraphNode<int>(1);
  //   graph1.AddNode(node1);
  //   Assert.That(graph1.Count, Is.EqualTo(1));
  //   Assert.That(graph1.Contains(1), Is.True);
  //   Assert.That(graph1.Contains(node1), Is.True);
  //   bool removed = graph1.Remove(node1);
  //   Assert.That(removed, Is.True);
  //   Assert.That(graph1.Contains(node1), Is.False);
  // }

  [Test]
  public void GetConnectedComponents()
  {
    Graph<int> graph1 = new Graph<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
    PrintGraph(graph1);
    // subgraph 1
    graph1.AddEdge(1, 2);
    graph1.AddEdge(1, 3);

    // subgraph 2
    graph1.AddEdge(4, 5);

    // subgraph 3
    graph1.AddEdge(6, 7);
    graph1.AddEdge(6, 8);
    graph1.AddEdge(6, 9);

    var subGraphs = graph1.GetConnectedComponents().ToList();

    int graphNum = 1;
    foreach (var graph in subGraphs)
    {
      Console.Write("Sub " + graphNum + ": ");
      foreach (var node in graph.Nodes)
      {
        Console.Write(node + ", ");
      }
      Console.WriteLine();
    }

    Assert.That(subGraphs.Count, Is.EqualTo(3));
  }

  private void PrintGraph(Graph<int> graph)
  {
    Console.WriteLine();
    foreach (var node in graph.Nodes)
    {
      Console.Write(node + ", ");  
    }
    Console.WriteLine();
  }
}