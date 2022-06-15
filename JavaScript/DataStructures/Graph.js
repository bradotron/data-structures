class Graph {
  constructor() {
    this.numVertices = 0;
    this.adjacencyList = new Map();
  }

  addVertex(v) {
    this.adjacencyList.set(v, []);
    this.numVertices++;
  }

  addEdge(v, w) {
    // add w to the adjacency list of v
    this.adjacencyList.get(v).push(w);

    // add v to the adjacency list of w
    this.adjacencyList.get(w).push(v);
  }

  printGraph() {
    let keys = this.adjacencyList.keys();

    // iterate over the vertices (keys of the adjacencyList)
    for (let i of keys) {
      let values = this.adjacencyList.get(i);
      let currentOutput = "";

      // iterate over the values and add to the output for this vertex
      for (let j of values) {
        currentOutput += j + " ";
      }

      // print the current vertex and it's adjacency list
      console.log(i + " - > " + currentOutput);
    }
  }

  bfs(startingNode) {
    // create a visited
    let visited = new Map();

    // create a queue for the search
    let q = [];

    // start from the startingNode
    visited.set(startingNode, true);
    q.push(startingNode);

    // loop until the queue is empty
    while (q.length > 0) {
      // get next queue element
      let queueElement = q.shift();

      // log current element
      console.log(queueElement);

      // get adjacencyList of current element
      let queueElementList = this.adjacencyList.get(queueElement);

      queueElementList.forEach(v => {
        if (!visited.get(v)) {
          visited.set(v, true);
          q.push(v);
        }
      });
    }
  }

  dfs(startingNode) {
    let visited = new Map();

    this.dfsUtil(startingNode, visited);
  }

  // recursive function to implement dfs by immitating a stack execution order
  dfsUtil(vertex, visited) {
    visited.set(vertex, true);
    console.log(vertex);

    let neighbors = this.adjacencyList.get(vertex);

    neighbors.forEach(v => {
      // if we haven't visited this neigher
      if (!visited.get(v)) {
        // add this to the recursion stack
        this.dfsUtil(v, visited);
      }
    });
  }

  isConnected() {
    // define a visited tracker to false for each vertex
    let visited = new Map();
    for (let v of this.adjacencyList.keys()) {
      visited.set(v, false);
    }

    // first vertex to visit = visited.keys().next().value
    this.traverse(visited.keys().next().value, visited);
    
    let values = [...visited.values()];
    console.log(values);
    return values.indexOf(false) < 0;
  }

  // a dfs traversal to determine connectivity
  traverse(vertex, visited) {
    // mark v as visited
    visited.set(vertex, true);

    // get all the adjacent vertices to v
    let neighbors = this.adjacencyList.get(vertex);
    // forEach neighbor vertex
    neighbors.forEach(v => {
      // if this neighbor hasn't been visited
      if (!visited.get(v)) {
        // add it to the recursion stack
        this.traverse(v, visited);
      }
    });
  }
}

module.exports = { Graph };
