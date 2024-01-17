using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class MovingAvg
    {
        public double Difference(int k, double[] data)
        {
            double maximum = 0;
            double minimum = 0;

            double sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += data[i];
            }

            maximum = sum / k;
            minimum = sum / k;

            for (int i = k; i < data.Length; i++)
            {
                sum += data[i] - data[i - k];

                maximum = Math.Max(maximum, sum / k);
                minimum = Math.Min(minimum, sum / k);
            }
            return maximum - minimum;
        }
    }
}
