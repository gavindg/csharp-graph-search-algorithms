// See https://aka.ms/new-console-template for more information
using GraphSearchAlgos;

// BreadthFirstSearchTests();
DepthFirstSearchTests();

void DepthFirstSearchTests()
{
    Graph graph = new Graph(example: true);
    
    Console.WriteLine("[Test] Possible path from A to E -- A:B:C:D:E : " + 
                      Algorithms.DepthFirstSearch(graph, "A", "E").Equals("A:B:C:D:E"));
    Console.WriteLine("[Test] No path from A to Z -- Z dne : " + 
                      Algorithms.DepthFirstSearch(graph, "A", "Z").Equals(""));
    Console.WriteLine("[Test] Possible path from W to E -- A:B:C:D:E : " +
                      Algorithms.DepthFirstSearch(graph, "W", "E").Equals(""));
}

// some tests for breadth-first search...
void BreadthFirstSearchTests()
{
    Graph graph = new Graph(example: true);

    Console.WriteLine("[Test] Length between B ^ E = 4: " + (
        Algorithms.BreadthFirstSearch(graph, "B", "E") == 4));
    
    Console.WriteLine("[Test] Length between A ^ B = 1: " + (
        Algorithms.BreadthFirstSearch(graph, "A", "B") == 1));
    
    Console.WriteLine("[Test] Length between A ^ C = Length between C ^ A: " + (
        Algorithms.BreadthFirstSearch(graph, "A", "C")
        == Algorithms.BreadthFirstSearch(graph, "C", "A")));
    
    Console.WriteLine("[Test] Length between A ^ Z = -1 (invalid, Z not an vert): " + (
        Algorithms.BreadthFirstSearch(graph, "A", "Z") == -1));
    
    Console.WriteLine("[Test] Length between G ^ E = -1 (invalid, G not a vert): " + (
        Algorithms.BreadthFirstSearch(graph, "G", "E") == -1));
}
