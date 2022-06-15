namespace DataLibrary;

public class BinaryTreeNode<T> : Node<T>
{
  private BinaryTreeNode<T>? left;
  private BinaryTreeNode<T>? right;

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
      return left;
    }
    set
    {
      if (left != null)
      {
        base.Neighbors.Remove(left);
      }

      left = value;

      if (value != null)
      {
        base.Neighbors.Add(left);
      }
    }
  }
  public BinaryTreeNode<T> Right
  {
    get
    {
      return right;
    }
    set
    {
      if (right != null)
      {
        base.Neighbors.Remove(right);
      }

      right = value;

      if (value != null)
      {
        base.Neighbors.Add(right);
      }
    }
  }
}
