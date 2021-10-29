using System;
using System.Collections.Generic;
using Xunit;
using UnionFind;


namespace qa
{
    public class WeightedQuickUnionUFQA
    {
        private class Test1Input
        {
            public int p = 0;
            public int q = 0;

            public Test1Input(int pi, int qi)
            {
                p = pi;
                q = qi;
            }
        }


        [Fact]
        public void Test1()
        {
            var inputs = new List<Test1Input> {
                new Test1Input(4,3),
                new Test1Input(3,8),
                new Test1Input(6,5),
                new Test1Input(9,4),
                new Test1Input(2,1),
                new Test1Input(8,9),
                new Test1Input(5,0),
                new Test1Input(7,2),
                new Test1Input(6,1),
                new Test1Input(1,0),
                new Test1Input(6,7)
                
            };
            WeightedQuickUnionUF u = new WeightedQuickUnionUF(10);
            foreach (var tt in inputs) {
                u.union(tt.p, tt.q);
            }

            Assert.Equal(2, u.Count());
        }
    }
}
