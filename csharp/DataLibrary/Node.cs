namespace DataLibrary;
public class Node<T>
{
  private T data;
  private NodeList<T> neighbors;

  public Node(T data)
  {
    this.data = data;
    this.neighbors = new NodeList<T>();
  }
  public Node(T data, NodeList<T> neighbors)
  {
    this.data = data;
    this.neighbors = neighbors;
  }

  public T Value
  {
    get
    {
      return data;
    }
    set
    {
      data = value;
    }
  }

  public NodeList<T> Neighbors
  {
    get
    {
      return neighbors;
    }
    set
    {
      neighbors = value;
    }
  }
}
