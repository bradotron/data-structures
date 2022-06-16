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
  }

  public BinaryTreeNode<T> Left
  {
    get
    {
      return left;
    }
    set
    {
      left = value;
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
      right = value;
    }
  }
}
