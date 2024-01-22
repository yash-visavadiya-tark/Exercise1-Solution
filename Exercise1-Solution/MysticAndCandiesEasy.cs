using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class MysticAndCandiesEasy
    {
        private List<int> BuildArrayGreedily(int totalCandy, int[] high)
        {
            List<int> arr = (from num in high
                            orderby num descending
                            select num).ToList();

            int sum = 0;
            for (int i = arr.Count - 1; i >= 0; i--)
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

        private int PickBoxGreedily(int minTarget, List<int> arr)
        {
            int numberOfBoxs = 0, sum = 0;

            foreach (int n in arr)
            {
                if (sum < minTarget)
                {
                    numberOfBoxs++;
                }
                sum += n;
            }
            return numberOfBoxs;
        }
     
        public int MinBoxes(int C, int X, int[] high)
        {
            List<int> arr = BuildArrayGreedily(totalCandy: C, high: high);

            return PickBoxGreedily(minTarget: X, arr);
        }
    }
}
