using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class SortingSubsets
    {
        private int[] SortedArray(int[] a)
        {
            int[] ans = new int[a.Length];

            a.CopyTo(ans, 0);
            Array.Sort(ans);

            return ans;
        }
        public int GetMinimalSize(int[] a)
        {
            int ans = 0;
            int[] arr = SortedArray(a);

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != arr[i])
                {
                    ans += 1;
                }
            }
            return ans;
        }
    }
}
