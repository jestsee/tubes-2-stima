using System;
using System.Collections.Generic;
using System.Text;

namespace tubes2stima
{
    class BFSsearch
    {
        public bool BFS(LinkedList<int>[] adj, int start, int end, Graph g, int[] p, int[] d)
        {
            ////// INISIALISASI //////
            // inisialisasi list untuk queue
            List<int> queue = new List<int>();

            // inisialisasi array of boolean
            bool[] visited = new bool[g.getNSimpul()];

            // semua elemen array of boolean diinisialisasi nilai false
            // array d (distance) diinisialisasi dengan infinit
            // array p (predecessor) diinisialisasi dengan -1
            for (int i = 0; i < g.getNSimpul(); i++)
            {
                visited[i] = false;
                d[i] = int.MaxValue;
                p[i] = -1;
            }

            // proses simpul start
            visited[start] = true;
            d[start] = 0;
            queue.Add(start);

            // selama queue tidak kosong
            while (queue.Count != 0)
            {
                int cur = queue[0];
                queue.RemoveAt(0);

                LinkedList<int> tetangga = adj[cur];
                foreach (var t in tetangga)
                {
                    if (!visited[t])
                    {
                        visited[t] = true;
                        d[t] = d[cur] + 1;
                        p[t] = cur;
                        queue.Add(t);

                        // kondisi berhenti
                        if (t == end)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public void printBFSPath(string start, string end, Graph g)
        {
            int s = g.getKey(start);
            int dest = g.getKey(end);
            int v = g.getNSimpul();
            int[] pred = new int[v];
            int[] dist = new int[v];
            LinkedList<int>[] adj = g.getAdjacent();

            if (BFS(adj, s, dest, g, pred, dist) == false)
            {
                Console.WriteLine("Tidak ada jalur koneksi yang tersedia");
                return;
            }

            List<int> path = new List<int>();
            int crawl = dest;
            path.Add(crawl);

            while (pred[crawl] != -1)
            {
                path.Add(pred[crawl]);
                crawl = pred[crawl];
            }

            // Print degree
            double deg = dist[dest];
            Console.WriteLine("{0}th degree connection", Math.Ceiling(deg / 2));

            // Print path
            for (int i = path.Count - 1; i > 0; i--)
            {
                Console.Write(g.getDictionary()[path[i]] + " -> ");
            }
            Console.Write(g.getDictionary()[path[0]]);
        }
    }
}
