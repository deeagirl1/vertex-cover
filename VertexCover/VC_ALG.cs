using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertexCover
{
    public class VC_ALG
    {

        #region Week 2
        public bool BruteForce(Graph graph, bool[] cover, int n, int i, int k)
        {
            if (k > n)
                return false;
            if (!graph.IsOkVertex)
            {
                return true;
            }

            if (i == n)
            {
                return graph.Validate(cover, n, k);
            }
            else
            {
                cover[i] = false;
                BruteForce(graph, cover, n, i + 1, k);
                if (!graph.IsOkVertex)
                {
                    return true;
                }

                cover[i] = true;
                BruteForce(graph, cover, n, i + 1, k);
                if (!graph.IsOkVertex)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Week 4
        public void enhanced_brute_force(Graph graph, int vertices)
        {
            int[] assignment = new int[vertices];
            List<int> cover = new List<int>();
            bool valid = false;

            while (!valid)
            {
                int candidateIndex = 0;
                int maxUncoveredNeighbours = 0;

                for (int i = 0; i < vertices; i++)
                {
                    if (assignment[i] != 1)
                    {
                        int sumUncovered = 0;
                        for (int j = 0; j < vertices; j++)
                        {
                            if (graph.get_adjacent_list()[i].Contains(j) && assignment[j] != 1)
                                sumUncovered++;
                        }
                        if (sumUncovered > maxUncoveredNeighbours)
                        {
                            candidateIndex = i;
                            maxUncoveredNeighbours = sumUncovered;
                        }
                    }
                }
                if (maxUncoveredNeighbours == 0)
                    valid = true;
                else
                {
                    cover.Add(candidateIndex);
                    assignment[candidateIndex] = 1;
                }
            }
            int size = 0;
            for (int i = 0; i < vertices; i++)
            {
                if (assignment[i] == 1)
                    size++;
            }
            #endregion
        }
    }
}
