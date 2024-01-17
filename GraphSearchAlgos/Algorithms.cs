namespace GraphSearchAlgos;

public static class Algorithms
{
    public static int BreadthFirstSearch(Graph graph, string start, string stop)
    {
        HashSet<Node> discovery = new HashSet<Node>();
        Node startNode = graph.FindNode(start);
        discovery.Add(startNode);

        while (discovery.Count > 0)
        {
            // remove a node at random from discovery = current
            // visit it
            // for each node adjacent to current
                // if not visited
                    // if current.Label == stop
                        // done
                    // else
                        // visit it
                        // add it to discovery.
        }
        
        return 0; // stub
    }
}