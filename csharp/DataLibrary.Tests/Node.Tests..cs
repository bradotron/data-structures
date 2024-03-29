using NUnit.Framework;
using DataLibrary;

namespace DataLibrary.Tests;

public class NodeTests
{
  [SetUp]
  public void Setup()
  {
  }

  [Test]
  public void Create()
  {
     Node<string> testNode2 = new DataLibrary.Node<string>("test");
    Assert.That(testNode2, Is.Not.Null);
    Assert.That(testNode2.Value, Is.EqualTo("test"));

    DataLibrary.NodeList<string> testNodeList1 = new DataLibrary.NodeList<string>();
    testNodeList1.Add(new Node<string>("neighbor1"));
    testNodeList1.Add(new Node<string>("neighbor2"));
    
    Node<string> testNode3 = new Node<string>("node", testNodeList1);
    Assert.That(testNode3, Is.Not.Null);
    Assert.That(testNode3.Value, Is.EqualTo("node"));
   
  }
}