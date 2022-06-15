namespace DataLibrary;

public class BinaryTreeNode<T> : Node<T>
{
  private BinaryTreeNode<T>? _Left;
  private BinaryTreeNode<T>? _Right;

  public BinaryTreeNode() { }
  public BinaryTreeNode(T data) : base(data) { }
  public BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
  {
    base.Value = data;
    Left = left;
    Right = right;

    NodeList<T> children = new NodeList<T>();

    if (Left != null)
    {
      children.Add(Left);
    }
    if (Right != null)
    {
      children.Add(Right);
    }

    base.Neighbors = children;
  }

  public BinaryTreeNode<T> Left
  {
    get
    {
      return _Left;
    }
    set
    {
      if (_Left != null)
      {
        base.Neighbors.Remove(_Left);
      }

      _Left = value;

      if (value != null)
      {
        base.Neighbors.Add(_Left);
      }
    }
  }
  public BinaryTreeNode<T> Right
  {
    get
    {
      return _Right;
    }
    set
    {
      if (_Right != null)
      {
        base.Neighbors.Remove(_Right);
      }

      _Right = value;

      if (value != null)
      {
        base.Neighbors.Add(_Right);
      }
    }
  }
}
