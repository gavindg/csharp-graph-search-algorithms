// See https://aka.ms/new-console-template for more information
using System.Collections;
using GraphSearchAlgos;

Graph graph = new Graph();
int length = Algorithms.BreadthFirstSearch(graph, "A", "B");

// Console.Out("Length between ")
