const {Graph} = require('./JavaScript/DataStructures/Graph');

let g = new Graph();
let vertices =  ['A', 'B', 'C', 'D', 'E', 'F'];

for(let i of vertices) {
  g.addVertex(i);
}

// console.log('Graph without Edges:')
// g.printGraph();
// console.log('-------------------');
// adding edges 
g.addEdge('A', 'B'); 
g.addEdge('A', 'D'); 
g.addEdge('A', 'E'); 
g.addEdge('B', 'C'); 
g.addEdge('D', 'E'); 
g.addEdge('E', 'F'); 
g.addEdge('E', 'C'); 
g.addEdge('C', 'F'); 

console.log('Graph with Edges:')
g.printGraph();
console.log('-------------------');

// console.log('BFS')
// g.bfs('A');
// console.log('-------------------');

console.log('DFS')
g.dfs('A');

console.log('-------------------');
console.log('g is connected? ' + g.isConnected());
console.log('-------------------');

// create a new graph that will be disconnected
let disconnected = new Graph();
for(let i = 0; i<5; i++) {
  disconnected.addVertex(i);
}

disconnected.addEdge(0, 1);
disconnected.addEdge(1, 2);
disconnected.addEdge(3, 4);

disconnected.printGraph();
console.log('g is connected? ' + disconnected.isConnected());


