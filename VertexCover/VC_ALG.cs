using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertexCover
{
    public class VC_ALG
    {
        public VC_ALG()
        {

        }

        public bool Validate(Graph g, bool[] cover, int n, int i, int k)
        {
            if (k > n)
                return false;
            if (!g.IsOkVertex)
            {
                return true;
            }

            if (i == n)
            {
                return (g.Validate(cover, n, k));
            }
            else
            {
                cover[i] = false;
                Validate(g, cover, n, i + 1, k);
                if (!g.IsOkVertex)
                {
                    return true;
                }

                cover[i] = true;
                Validate(g, cover, n, i + 1, k);
                if (!g.IsOkVertex)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
