class Node {
  // constructor
  constructor(data) {
    this.data = data;
    this.next = null;
  }
}

class LinkedList {
  // constructor
  constructor() {
    this.head = null;
    this.size = 0;
  }

  // add data to the end of the list
  add(data) {
    // create a new node
    let node = new Node(data);

    // store for current node
    let current;

    // if list is empty, add node to head
    // else traverse the list to the final node
    if (this.head == null) {
      this.head = node;
    } else {
      current = this.head;

      while (current.next) {
        current = current.next;
      }

      current.next = node;
    }

    // increment the size
    this.size++;
  }

  // insert data at the given index in the list
  // return true if successful, false otherwise
  insertAt(data, index) {
    // if index is not valid, return false
    if (index < 0 || index > this.size) {
      return false;
    } else {
      // create new node
      let node = new Node(data);
      let current, previous;

      current = this.head;

      // traverse list to insertion index
      for (let i = 0; i < index; i++) {
        previous = current;
        current = current.next;
      }

      // add the element
      node.next = current;
      previous.next = node;
    }

    this.size++;
  }

  removeFrom(index) {
    if (index < 0 || index > this.size) {
      return -1;
    } else {
      let current = this.head;
      let previous;

      if (index == 0) {
        this.head = current.next;
      } else {
        for (let i = 1; i < index; i++) {
          previous = current;
          current = current.next;
        }
        previous.next = current.next;
      }
      this.size--;
      return current.data;
    }
  }

  // TODO
  // removeData(data)

  // Helpers
  // TODO
  isEmpty() {
    return this.size == 0;
  }

  getSize() {
    return this.size;
  }

  printList() {
    let current = this.head;
    let output = "";
    while (current) {
      output += current.data + ' ';
      current = current.next;
    }
    console.log(output);
  }
}

module.exports = [Node, LinkedList];
