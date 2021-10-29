using System;

namespace UnionFind
{
    public class WeightedQuickUnionUF
    {
        private int[] id; // parent link (site indexed)
        private int[] sz; // size of component for roots (site indexed)
        private int count; // number of components

        public WeightedQuickUnionUF(int n)
        {
            count = n;
            id = new int[n];
            for (int i = 0; i < n; i++) {
                id[i] = i;
            }
            sz = new int[n];
            for (int i = 0; i < n; i++) {
                sz[i] = 1;
            }
        }

        public int Count()
        {
            return count;
        }

        public bool connected(int p, int q)
        {
            return find(p) == find(q);
        }

        public int find(int p)
        {
            while (p != id[p]) {
                p = id[p];
            }

            return p;
        }

        public void union(int p, int q)
        {
            int i = find(p);
            int j = find(q);

            if (i == j) {
                return;
            }

            if (sz[i] < sz[j]) {
                id[i] = j;
                sz[j] += sz[i];
            } else {
                id[j] = i;
                sz[i] += sz[j];
            }
            count--;
        }
    }
}
