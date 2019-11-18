const assert = require("assert");
const { Queue } = require("../DataStructures/Queue");

describe("Test cases for Queue", function() {
  describe("#constructor", function() {
    it("should create an empty list", function() {
      let myQueue = new Queue();
      assert.equal(myQueue.queue.length, 0);
    });
  });

  describe("enqueue function", function() {
    it("Should return true on success", function() {
      let myQueue = new Queue();
      assert.equal(myQueue.enqueue(20), true);
      assert.equal(myQueue.queue[myQueue.rear], 20);
    });
    it("return false otherwise", function() {
      let myQueue = new Queue();
      assert.equal(myQueue.enqueue(), false);
    });
  });

  describe("dequeue function", function() {
    it("should remove and return the first element of the queue", function() {
      let myQueue = new Queue();
      myQueue.enqueue(1);
      myQueue.enqueue(2);
      myQueue.enqueue(3);
      assert.equal(myQueue.dequeue(), 1);
    });
  });
});
