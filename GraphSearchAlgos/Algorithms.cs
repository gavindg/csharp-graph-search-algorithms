using System.Transactions;

namespace GraphSearchAlgos;

public static class Algorithms
{
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