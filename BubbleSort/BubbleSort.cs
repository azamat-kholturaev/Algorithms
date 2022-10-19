using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class BubbleSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            var count = Items.Count;

            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    var a = Items[i];
                    var b = Items[i + 1];

                    if (a.CompareTo(b) == 1)
                    {
                        Swop(i, i + 1);
                    }
                }
                count--;
            }
        }
    }
}
