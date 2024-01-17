namespace GraphSearchAlgos;

public class Graph
{
    private List<Node> _nodes;

    public Graph()
    {
        // initialize list
        _nodes = new List<Node>();
        
        // create nodes
        Node graphHead = new Node("A");
        Node b = new Node("B");
        Node c = new Node("C");
        Node d = new Node("D");
        Node e = new Node("E");
        
        _nodes.Add(graphHead);
        _nodes.Add(b);
        _nodes.Add(c);
        _nodes.Add(d);
        _nodes.Add(e);
        
        // create edges
        
        AddUndirectedEdge(graphHead, b);
        AddUndirectedEdge(b, c);
        AddUndirectedEdge(b, d);
        AddUndirectedEdge(c, d);
        AddUndirectedEdge(d, e);
    }

    public Node FindNode(string label)
    {
        for (int i = 0; i < _nodes.Count; i++)
        {
            if (_nodes[i].Label == label)
            {
                return _nodes[i];
            }
        }

        return new Node("NONODE", errorStatus: true); 
    }

    private void AddUndirectedEdge(Node from, Node to)
    {
        from.Connections.Add(to);
        to.Connections.Add(from);
    }
}