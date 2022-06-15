using NUnit.Framework;
using DataLibrary;

namespace DataLibrary.Tests;

public class BinaryTreeTests
{
  [SetUp]
  public void Setup()
  {
  }

  [Test]
  public void Create()
  {
    BinaryTree<int> bTree = new BinaryTree<int>();
    Assert.That(bTree, Is.Not.Null);
  }

  public void BuildATestTree()
  {
    BinaryTree<int> btree = new BinaryTree<int>();
    btree.Root = new BinaryTreeNode<int>(1);
    btree.Root.Left = new BinaryTreeNode<int>(2);
    btree.Root.Right = new BinaryTreeNode<int>(3);

    btree.Root.Left.Left = new BinaryTreeNode<int>(4);
    btree.Root.Right.Right = new BinaryTreeNode<int>(5);

    btree.Root.Left.Left.Right = new BinaryTreeNode<int>(6);
    btree.Root.Right.Right.Right = new BinaryTreeNode<int>(7);

    btree.Root.Right.Right.Right.Right = new BinaryTreeNode<int>(8);

    Assert.That(btree.Root.Value, Is.EqualTo(1));
    Assert.That(btree.Root.Left.Left.Right.Value, Is.EqualTo(6));
    Assert.That(btree.Root.Right.Right.Right.Right, Is.EqualTo(8));
  }
}