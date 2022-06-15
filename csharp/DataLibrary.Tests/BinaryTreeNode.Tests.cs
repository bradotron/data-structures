using NUnit.Framework;
using DataLibrary;

namespace DataLibrary.Tests;

public class BinaryTreeNodeTests
{
  [SetUp]
  public void Setup()
  {
  }

  [Test]
  public void Create()
  {
    BinaryTreeNode<string> testNode = new BinaryTreeNode<string>();
    Assert.That(testNode, Is.Not.Null);
  }

  public void SetLeftAndRight() {
    BinaryTreeNode<string> left = new BinaryTreeNode<string>("left");
    BinaryTreeNode<string> right = new BinaryTreeNode<string>("right");

    BinaryTreeNode<string> testNode = new BinaryTreeNode<string>("test", left, right);

    Assert.That(testNode, Is.Not.Null);
    Assert.That(testNode.Left, Is.EqualTo(left));
    Assert.That(testNode.Right, Is.EqualTo(right));

    testNode.Left = null;
    Assert.That(testNode.Left, Is.Null);
    Assert.That(testNode.Neighbors.Count, Is.EqualTo(1));
    testNode.Right = null;
    Assert.That(testNode.Right, Is.Null);
    Assert.That(testNode.Neighbors.Count, Is.EqualTo(0));
  }
}