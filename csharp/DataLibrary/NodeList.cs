using System.Collections.ObjectModel;

namespace DataLibrary;

public class NodeList<T> : Collection<Node<T>>
{
  public NodeList() : base() { }

  public Node<T> FindByValue(T value)
  {
    foreach (Node<T> node in Items)
    {
      if (node.Value.Equals(value))
      {
        return node;
      }
    }

    return null;
  }
}