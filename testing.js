const [Node, LinkedList] = require('./LinkedList');

let testList = new LinkedList();

console.log(testList.isEmpty());

testList.add(10);
testList.add(20);
testList.add(30);
testList.add(40);
testList.add(50);

testList.printList();

console.log(testList.isEmpty());

console.log(testList.getSize());

console.log('Removing index 0: ' + testList.removeFrom(0) );

testList.printList();

console.log(testList.getSize());

testList.insertAt(69, 3);
testList.printList();
console.log(testList.getSize());

testList.insertAt('potato', 3);
testList.printList();
console.log(testList.getSize());


