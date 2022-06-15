const assert = require("assert");
const { Node, LinkedList } = require("../DataStructures/LinkedList");

describe("LinkedList", function() {
  describe("#constructor", function() {
    it("should create an empty list", function() {
      let List = new LinkedList();
      assert.equal(List.getSize(), 0);
    });
    // it("should create an empty list regardless of input", function() {
    //   let List1 = new LinkedList(123);
    //   let List2 = new LinkedList('abce');
    //   let List3 = new LinkedList([1, 2, 3, 4]);
    // });
  });
});
