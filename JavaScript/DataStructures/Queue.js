class Queue {
  constructor() {
    this.front = 0;
    this.rear = 0;
    this.queue = [];
  }

  enqueue(data) {
    if(data) {
      this.queue[this.rear] = data;
      return true;
    } else {
      return false;
    }  
  }

  dequeue() {

  }
}

module.exports = { Queue };
