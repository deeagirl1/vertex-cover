using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertexCover
{
    public class Graph
    {
        private List<int> verticiesToConnect = new List<int>();
        private List<List<int>> adjList;
        private int vertices;
        private Random random = new Random();

        public List<List<int>> get_AdjList()
        {
            return adjList;
        }

        public int get_vertices() { return vertices; }


        public void create_graph (int v)
        {
            this.vertices = v;
            adjList = new List<List<int>>();

            foreach (var vertex in adjList)
            {
                adjList.Add(vertex);
            }
        }

        public bool add_edge(int source, int destination)
        {
            if (adjList[source].Contains(destination) || source == destination)
            {
                return false;
            }
            adjList[source].Add(destination);
            adjList[destination].Add(source);
            return true;
        }

        public void connect()
        {
            foreach (var vertex in verticiesToConnect)
            {
                add_edge(verticiesToConnect[0], vertex);
            }
        }

        public void ReachableVert(int v, bool[] visited, bool foundArbitraryVertice)
        {
            if (!foundArbitraryVertice)
            {
                verticiesToConnect.Add(v);
                foundArbitraryVertice = true;
            }

            // Mark the current node as visited and print it
            visited[v] = true;
            Console.Write(/*"f "+*/ v + " ");
            // Recur for all the vertices
            // adjacent to this vertex
            foreach (int x in adjList[v])
            {
                if (!visited[x])
                {
                    ReachableVert(x, visited, foundArbitraryVertice);
                }
                    
            }
        }



        public void connectedComponents()
        {
            // Mark all the vertices as not visited
            bool[] visited = new bool[vertices];
            for (int v = 0; v < vertices; v++)
            {
                if (!visited[v])
                {
                    // print all reachable vertices
                    // from v
                    ReachableVert(v, visited, false);
                    Console.WriteLine();
                }
            }
        }

        public void add_edges_on_probability(int prob)
        {
            for (int i = 0; i< vertices; i++)
            {
                for(int j = i + 1; j < vertices; j++)
                {
                    int probability = random.Next(1, 101);
                       if (probability <= prob)
                       {
                          add_edge(i, j);
                       }
                }
            }
        }

       public void write_graph_to_file()
        {
            FileStream fileStream = null;
            StreamWriter streamWriter = null;

            try
            {
                fileStream = new FileStream("graph.dot", FileMode.Open, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);

                streamWriter.WriteLine("graph my_graph { node[fontname = Arial, style = \"filled,setlinewidth(4)\",shape = circle]");

                for (int i = 0; i < adjList.Count(); i++)
                {
                    streamWriter.WriteLine("node" + i + "[ label =\" " + i + "\"]");
                }

                for (int i = 0; i < adjList.Count(); i++)
                {
                    for (int j = 0; j < adjList[i].Count(); j++)
                    {
                        if (adjList[i][j] >= i)
                        {
                            streamWriter.WriteLine("node" + i + "--" + "node" + adjList[i][j]);
                        }
                    }
                }
                streamWriter.WriteLine("}");

            }
            catch (IOException)
            {
                throw;
            }
            catch (Exception e)
            {
                //throw;
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }

        }
    }
}
