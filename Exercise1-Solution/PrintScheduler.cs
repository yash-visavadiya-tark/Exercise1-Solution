using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class PrintScheduler
    {
        private Dictionary<int,int> InitializeAllThreadIndex(int n)
        {
            Dictionary<int, int> mapInd = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                mapInd[i] = 0;
            }

            return mapInd;
        }

        private String RunThreadsAndReturnResult(String[] threads, String[] slices, Dictionary<int, int> threadIndex)
        {
            var ans = new StringBuilder("");

            for (int i = 0; i < slices.Length; i++)
            {
                String[] slice = slices[i].Split(' ');

                int ind = int.Parse(slice[0]);
                int time = int.Parse(slice[1]);
                while (time > 0)
                {
                    ans.Append(threads[ind][threadIndex[ind]]);
                    threadIndex[ind]++;
                    time--;
                    if (threadIndex[ind] == threads[ind].Length)
                    {
                        threadIndex[ind] = 0;
                    }
                }
            }
            return ans.ToString();
        }

        public String GetOutput(String[] threads, String[] slices)
        {
            Dictionary<int, int> threadIndex = InitializeAllThreadIndex(threads.Length);

            return RunThreadsAndReturnResult(threads, slices, threadIndex);
        }
    }
}
