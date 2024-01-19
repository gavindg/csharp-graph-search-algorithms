namespace GraphSearchAlgos;

public static class Algorithms
{
    public static string DepthFirstSearch(Graph graph, string start, string stop)
    {
        graph.UnvisitAll();
        Node startNode = graph.FindNode(start);

        if (startNode == null)
        {
            return "";
        }

        bool done = false;
        return DepthFirstSearch(startNode, stop, done: ref done);
    }

    private static string DepthFirstSearch(Node current, string stop, ref bool done)
    {
        if (!current.IsVisited())
        {
            current.Visit();
            if (current.Label == stop)
            {
                done = true;
                return current.Label;
            }
            foreach (Node n in current.Connections)
            {
                string path = DepthFirstSearch(n, stop, ref done);
                if (done)
                {
                    return current.Label + ":" + path;
                }
            }
        }
        return "";
    }
    
    public static int BreadthFirstSearch(Graph graph, string start, string stop)
    {
        graph.UnvisitAll();
        int length = 1;
        Queue<Node> currentLayer = new Queue<Node>();
        Node startNode = graph.FindNode(start);
        if (startNode == null)
        {
            return -1;
        }
        
        currentLayer.Enqueue(startNode);

        while (currentLayer.Count > 0)
        {
            Node current = currentLayer.Dequeue();
            current.Visit();
            
            // check each node that neighbors the current...
            foreach (Node node in current.Connections)
            {
                if (!node.IsVisited())
                {
                    if (node.Label == stop)
                    {
                        // done
                        return length;
                    }
                    currentLayer.Enqueue(node);
                }
            }
            
            length++;
        }
        
        return -1;  // invalid: end node does not exist...
    }
}