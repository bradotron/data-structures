using System.Collections.ObjectModel;

namespace DataLibrary;

public class Graph<T>
{
  public Dictionary<T, HashSet<T>> nodeNeighbors;

  public IEnumerable<T> Nodes
  {
    get
    {
      return nodeNeighbors.Keys;
    }
  }

  public Graph()
  {
    this.nodeNeighbors = new Dictionary<T, HashSet<T>>();
  }

  public Graph(IEnumerable<T> nodes)
  {
    this.nodeNeighbors = new Dictionary<T, HashSet<T>>();
    this.AddNodes(nodes);
  }

  public void AddNode(T node)
  {
    this.nodeNeighbors.Add(node, new HashSet<T>());
  }

  public void AddNodes(IEnumerable<T> nodes)
  {
    foreach (T node in nodes)
    {
      this.AddNode(node);
    }
  }

  public void AddEdge(T from, T to)
  {
    if (ContainsNode(from) && ContainsNode(to))
    {
      this.nodeNeighbors[from].Add(to);
      this.nodeNeighbors[to].Add(from);
    }
    else
    {
      throw new Exception("Graph does not contain both nodes");
    }
  }

  public bool ContainsNode(T node)
  {
    return nodeNeighbors.ContainsKey(node);
  }

  public IEnumerable<T> GetNeighbors(T node)
  {
    return nodeNeighbors[node];
  }

  public IEnumerable<T> DepthFirstSearch(T startNode)
  {
    Stack<T> stack = new Stack<T>();
    HashSet<T> visited = new HashSet<T>();

    stack.Push(startNode);

    while (stack.Count > 0)
    {
      T current = stack.Pop();
      if (!visited.Contains(current))
      {
        visited.Add(current);
        yield return current;
        foreach (T next in GetNeighbors(current))
        {
          stack.Push(next);
        }
      }
    }
  }

  public Graph<T> GetSubGraph(IEnumerable<T> nodes)
  {
    Graph<T> graph = new Graph<T>();
    graph.AddNodes(nodes);
    foreach (T node in graph.Nodes.ToList())
    {
      foreach (T neighbor in this.GetNeighbors(node))
      {
        graph.AddEdge(node, neighbor);
      }
    }
    return graph;
  }

  public IEnumerable<Graph<T>> GetConnectedComponents()
  {
    HashSet<T> visited = new HashSet<T>();
    List<Graph<T>> components = new List<Graph<T>>();

    foreach (T node in this.Nodes)
    {
      if (!visited.Contains(node))
      {
        Graph<T> subGraph = GetSubGraph(this.DepthFirstSearch(node));
        components.Add(subGraph);
        visited.UnionWith(subGraph.Nodes);
      }
    }

    return components;
  }
}