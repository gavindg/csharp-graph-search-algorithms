namespace GraphSearchAlgos;
using System.Collections;

public class Node
{
    public string Label { get; set; }
    public List<Node> Connections;
    private bool _visited = false;
    

    public Node(string label)
    {
        Connections = new List<Node>();
        Label = label;

    }

    public void Visit() => _visited = true;
    public void UnVisit() => _visited = false;

    public bool IsVisited()
    {
        return _visited;
    }
}