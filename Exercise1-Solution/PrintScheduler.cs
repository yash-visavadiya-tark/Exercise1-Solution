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
            int index = 0;
            Dictionary<int, int> threadIndex = threads.ToDictionary(key => index++, value => 0);

            return RunThreadsAndReturnResult(threads, slices, threadIndex);
        }
    }
}
