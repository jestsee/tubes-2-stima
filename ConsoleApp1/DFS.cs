using System;
using System.Linq;
using System.Collections.Generic;

namespace tubes2stima
{
    class DFS
    {
        public void StartDFS(string start, string destination, Graph graph)
        {
            List<string> route = new List<string>();
            var _visited = new HashSet<string>();
            int idx = 0;
            int degreeConnection = 0;
            string value = "";
            foreach (var a in graph.getDictionary())
            {
                graph.getDictionary().TryGetValue(a.Key, out value);
                if (Equals(value, start))
                {
                    idx = a.Key;
                    break;
                }
            }
            DepthFirstSearch(idx, start, destination, route, graph, _visited);
            if (route.Contains(destination))
            {
                foreach (var a in route)
                {
                    if (!Equals(a, destination))
                    {
                        Console.Write(a + "->");
                    }
                    else
                    {
                        Console.WriteLine(a);
                    }
                    degreeConnection++;
                }
                Console.WriteLine(degreeConnection - 2 + "-th connection"); // use converter later for st, nd, rd, th...
            }
            else
            {
                Console.WriteLine("No connection");
            }
        }

        public void DepthFirstSearch(int i, string start, string destination, List<string> route, Graph graph, HashSet<string> _visited)
        {
            _visited.Add(start);
            if (!_visited.Contains(destination))
            {
                route.Add(start);
                foreach (var b in graph.getAdjacent()[i])
                {
                    if (!_visited.Contains(graph.getDictionary()[b]))
                    {
                        DepthFirstSearch(b, graph.getDictionary()[b], destination, route, graph, _visited);
                    }
                }
            }
            if (Equals(start, destination))
            {
                route.Add(destination);
            }
        }
    }
}
