using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class MysticAndCandiesEasy
    {
        private int[] BuildArrayGreedily(int totalCandy, int[] high)
        {
            int[] arr = high.OrderByDescending(c => c).ToArray();
            int sum = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                sum += arr[i];
                if (totalCandy - sum <= 0)
                {
                    sum -= arr[i];
                    arr[i] = totalCandy - sum;
                    sum += totalCandy - sum;
                }
            }
            return arr;
        }

        private int PickBoxGreedily(int minTarget, int[] arr)
        {
            int ans = 0, sum = 0;
            foreach (int n in arr)
            {
                if (sum < minTarget)
                {
                    ans++;
                }
                sum += n;
            }
            return ans;
        }
     
        public int MinBoxes(int C, int X, int[] high)
        {
            int[] arr = BuildArrayGreedily(totalCandy: C, high: high);

            return PickBoxGreedily(minTarget: X, arr);
        }
    }
}
