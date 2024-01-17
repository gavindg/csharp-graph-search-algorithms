namespace GraphSearchAlgos;
using System.Collections;

public struct Node
{
    public string Label { get; set; }
    public List<Node> Connections;
    private bool isVisited = false;
    private bool valid = true;
    

    public Node(string label, bool errorStatus=false)
    {
        Connections = new List<Node>();
        Label = label;
        valid = !errorStatus;
    }

    public bool Validate()
    {
        return valid;
    }
}