using NUnit.Framework;
using DataLibrary;

namespace DataLibrary.Tests;

public class NodeListTests
{
  [Test]
  public void Create()
  {
    NodeList<string> stringNodeList = new NodeList<string>();
    Assert.That(stringNodeList, Is.Not.Null);
  }

  [Test]
  public void Add()
  {
    NodeList<string> testNodeList1 = new NodeList<string>();
    testNodeList1.Add(new Node<string>("test1"));
    Assert.That(testNodeList1.Count, Is.EqualTo(1));
    testNodeList1.Add(new Node<string>("test2"));
    Assert.That(testNodeList1.Count, Is.EqualTo(2));
  }

  [Test]
  public void Remove()
  {
    NodeList<string> testNodeList1 = new NodeList<string>();
    Node<string> node1 = new Node<string>("test1");
    Node<string> node2 = new Node<string>("test2");
    testNodeList1.Add(node1);
    testNodeList1.Add(node2);
    Assert.That(testNodeList1.Count, Is.EqualTo(2));
    testNodeList1.Remove(node1);
    Assert.That(testNodeList1.Count, Is.EqualTo(1));
    testNodeList1.Remove(node2);
    Assert.That(testNodeList1.Count, Is.EqualTo(0));
  }
}