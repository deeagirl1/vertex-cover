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
        #region Properties 
        private List<int> verticiesToConnect = new List<int>();
        private List<List<int>> adjacent_list;
        public int Vertices { get; set; }
        private Random random = new Random();
        public bool IsOkVertex { get; set; } = true;
        public int progress { get; set; } = 0;
        public List<int> Tops { get; set; } = new List<int>();
        public List<int> Pendants { get; set; } = new List<int>();
        public List<int> IsolatedVertices { get; set; } = new List<int>();
        #endregion

        #region Week 1
        public List<List<int>> get_adjacent_list()
        {
            return adjacent_list;
        }

        public void create_graph (int v)
        {
            this.Vertices = v;
            adjacent_list = new List<List<int>>();

            for (int i = 0; i < v; i++)
            {
                adjacent_list.Add(new List<int>());
            }
        }

        public bool add_edge(int source, int destination)
        {
            if (adjacent_list[source].Contains(destination) || source == destination)
            {
                return false;
            }
            adjacent_list[source].Add(destination);
            adjacent_list[destination].Add(source);
            return true;
        }

        public void connect()
        {
            foreach (int vertex in verticiesToConnect)
            {
                add_edge(verticiesToConnect[0], vertex);
            }
        }

        public void reachable_vertex(int v, bool[] visited, bool foundArbitraryVertice)
        {
            if (!foundArbitraryVertice)
            {
                verticiesToConnect.Add(v);
                foundArbitraryVertice = true;
            }

            // Mark the current node as being visited and print it.
            visited[v] = true;
            // Recur for all the vertices adjacent to this vertex.
            foreach (int x in adjacent_list[v])
            {
                if (!visited[x])
                {
                    reachable_vertex(x, visited, foundArbitraryVertice);
                }
                    
            }
        }

        public void components()
        {
            // Mark all the vertices as being not visited.
            bool[] visited = new bool[Vertices];
            for (int i = 0; i < Vertices; i++)
            {
                if (!visited[i])
                {
                    // Print all reachable vertices from vertex v.
                    reachable_vertex(i, visited, false);
                }
            }
        }

        public void add_edges_on_probability(int prob)
        {
            for (int i = 0; i< Vertices; i++)
            {
                for(int j = i + 1; j < Vertices; j++)
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

                for (int i = 0; i < adjacent_list.Count(); i++)
                {
                    streamWriter.WriteLine("node" + i + "[ label =\" " + i + "\"]");
                }

                for (int i = 0; i < adjacent_list.Count(); i++)
                {
                    for (int j = 0; j < adjacent_list[i].Count(); j++)
                    {
                        if (adjacent_list[i][j] >= i)
                        {
                            streamWriter.WriteLine("node" + i + "--" + "node" + adjacent_list[i][j]);
                        }
                    }
                }
                streamWriter.WriteLine("}");

            }
            catch (IOException)
            {
                throw;
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }

        }

        #endregion

        #region Week 2

        public bool Validate(bool[] cover, int n, int k)
        {
            if (!IsOkVertex)
            {
                return true;
            }

            int count = 0;

            for (int i = 0; i < cover.Length; i++)
            {
                if(cover[i] == true)
                {
                    count++;
                    progress++;
                }
            }

            bool IsReached = true;
            if(count == k)
            {
                for (int i = 0; i < cover.Length; i++)
                {
                    for (int j = 0; j < adjacent_list[i].Count; j++)
                    {
                        if ((cover[i] == false) && (cover[adjacent_list[i][j]] == false))
                        {
                            IsReached = false;
                            return false;
                        }
                    }
                }
            }
            else
            {
                IsReached = false;
                return false;
            }

            if (IsReached)
            {
                IsOkVertex = false;
            }

            return IsReached;
        }

        #endregion

        #region Week 3 

        public void kernelization(int k)
        {
            findPendants();
            find_tops(k);
            find_isolated_vertices();
        }

        // a function to find the pendants of the graph
        private void findPendants()
        {
            Pendants.Clear();

            // iterate through the vertices of the graph 
            for (int i = 0; i < Vertices; i++)
            {
                // checks if the vertex is leaf and only has one adjacent vertex
                if (adjacent_list[i].Count == 1)
                {
                    // make sure that Pendants list does not contain the current vertex
                    if (!Pendants.Contains(i))
                    {
                        bool ok = true;
                        // iterate through all pendants elements to make sure that the adjacents of the elements
                        // does not contain the current vertex
                        foreach (int pendant in Pendants)
                        {
                            if (adjacent_list[pendant].Contains(i))
                            {
                                ok = false;
                            }
                        }
                        //if we found the pendant we add it to the pendants list
                        if (ok) 
                        {
                            Pendants.Add(i);
                        } 
                    }
                }
            }
        }

        private void find_tops(int k)
        {
            Tops.Clear();

            // iterate through the vertices of the graph 
            for (int i = 0; i < Vertices; i++)
            {
                // checks if the current vertex has more adjacent than the (k edges) 
                if (adjacent_list[i].Count > k)
                {
                    // adds the current vertex to the Tops vertices list
                    if (!Tops.Contains(i))
                    {
                        Tops.Add(i);
                    }    
                }
            }
        }

        private void find_isolated_vertices()
        {
            IsolatedVertices.Clear();

            // iterate through the vertices of the graph 
            for (int i = 0; i < Vertices; i++)
            {
                // checks if the current vertex is not connected to any vertices in the graph
                if (adjacent_list[i].Count == 0)
                {
                    // adds the current vertex to the Isolated Vertices list
                    if (!IsolatedVertices.Contains(i))
                    {
                        IsolatedVertices.Add(i);
                    }   
                }
            }
        }

        public override string ToString()
        {
            string str = "Pendants: " + Pendants + "\n" +
                         "Isolated Vertices: " + IsolatedVertices + "\n" +
                         "Tops: " + Tops + "\n";
            return str;
        }

        // a function to update a color of a vertices 
        public void updateColorGraphToFile()
        {
            FileStream fileStream = null;
            StreamWriter streamWriter = null;

            try
            {
                fileStream = new FileStream("graph.dot", FileMode.Open, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);


                streamWriter.WriteLine("graph my_graph { node[fontname = Arial, style = \"filled,setlinewidth(4)\",shape = circle]");

                for (int i = 0; i < adjacent_list.Count(); i++)
                {
                    if (Tops.Contains(i))
                        streamWriter.WriteLine("node" + i + "[ label =\" " + i + "\" color=\"#4040f040\"]");
                    else if (Pendants.Contains(i))
                        streamWriter.WriteLine("node" + i + "[ label =\" " + i + "\" color=\"#40f04040\"]");
                    else if (IsolatedVertices.Contains(i))
                        streamWriter.WriteLine("node" + i + "[ label =\" " + i + "\" color=\"#f0404040\"]");
                    else
                        streamWriter.WriteLine("node" + i + "[ label =\" " + i + "\"]");
                }

                for (int i = 0; i < adjacent_list.Count(); i++)
                {
                    for (int j = 0; j < adjacent_list[i].Count(); j++)
                    {
                        if (adjacent_list[i][j] >= i)
                        {
                            streamWriter.WriteLine("node" + i + "--" + "node" + adjacent_list[i][j]);
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

        // a function to remove an edge between two vertices 
        public bool remove_edge(int src, int dest)
        {
            if (adjacent_list[src].Contains(dest) && adjacent_list[dest].Contains(src))
            {
                adjacent_list[src].Remove(dest);
                adjacent_list[dest].Remove(src);
                return true;
            }
            return false;
        }

        // a function to increment the Tops of the graph
        public void top_increment(int k)
        {
            // iterate through the vertices of the graph 
            for (int i = 0; i < Vertices; i++)
            {
                // checks if the current vertex is less or equal than (k edges) 
                if (adjacent_list[i].Count <= k)
                {
                    // iterate through the rest of vertices of the graph 
                    for (int j = 0; j < Vertices; j++)
                    {
                        // checks if the j vertex is less or equal than (k edges) 
                        if (adjacent_list[j].Count <= k)
                        {
                            // we add new edge between i and j 
                            add_edge(i, j);
                        }
                    }
                    // we add the current vertex to the Tops list
                    if (!Tops.Contains(i))
                    {
                        Tops.Add(i);
                    }
                    // out of for-loop to avoid looping forever
                    break;
                }
            }
        }

        public void top_decrement(int k)
        {
            for (int i = 0; i < Vertices; i++)
            {
                if (adjacent_list[i].Count > k)
                {
                    for (int j = 0; j < Vertices; j++)
                    {
                        if (adjacent_list[j].Count > k)
                        {
                            remove_edge(i, j);
                        }
                    }
                    if (Tops.Contains(i))
                    {
                        Tops.Remove(i);
                    }   
                    break;
                }
            }
        }

        public void pendants_increment()
        {
            for (int i = 0; i < Vertices; i++)
            {
                if (adjacent_list[i].Count > 1)
                {
                    for (int j = 0; j < Vertices; j++)
                    {
                        if (adjacent_list[j].Count > 1)
                        {
                            remove_edge(i, j);
                        }
                    }
                    if (!Pendants.Contains(i))
                    {
                        Pendants.Add(i);
                    }
                    break;
                }
            }
        }

        public void pendants_decrement()
        {
            for (int i = 0; i < Vertices; i++)
            {
                if (adjacent_list[i].Count == 1)
                {
                    for (int j = 0; j < Vertices; j++)
                    {
                        if (adjacent_list[j].Count == 1)
                        {
                            add_edge(i, j);
                        }
                    }
                    if (Pendants.Contains(i))
                    {
                        Pendants.Remove(i);
                    }
                    break;
                }
            }

        }

        #endregion

    }
}
