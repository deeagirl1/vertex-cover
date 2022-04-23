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
            {
                return false;
            }

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
        public bool enhanced_brute_force(Graph g, int[] cover, int n, int i, int k)
        {
            
            if (k > n)
            {
                return false;
            }

            if (!g.IsOkVertex)
            {
                return true;
            }

            if (i == n)
            {
                return g.ValidateSmart(cover, n, k);
            }

            else
            {
                if (cover[i] == 0 || cover[i] == 1)
                {
                    if (g.Pendants.Contains(i) || g.IsolatedVertices.Contains(i))
                    {
                        cover[i] = 0; 
                        enhanced_brute_force(g, cover, n, i + 1, k);
                        if (!g.IsOkVertex)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        cover[i] = 0;
                        enhanced_brute_force(g, cover, n, i + 1, k);
                        if (!g.IsOkVertex)
                        {
                            return true;
                        }

                        cover[i] = 1;
                        enhanced_brute_force(g, cover, n, i + 1, k);
                        if (!g.IsOkVertex)
                        {
                            return true;
                        }
                    }
                }
                else if (cover[i] == 2)
                {
                    enhanced_brute_force(g, cover, n, i + 1, k);
                    if (!g.IsOkVertex)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion
    }
}
