using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class TurningLightOn
    {

        private void InitializeDP(String last, int[] dp)
        {
            int j = dp.Length - 1;
            int cost = 0;
            while (j >= 0)
            {
                if (last[j] == '0')
                {
                    cost++;
                    while (j >= 0 && last[j] == '0')
                    {
                        dp[j] = cost;
                        j--;
                    }
                }
                else
                {
                    if (j + 1 < dp.Length && last[j + 1] == '0')
                        cost++;
                    while (j >= 0 && last[j] == '1')
                    {
                        dp[j] = cost;
                        j--;
                    }
                }
            }
        }
     
        public int MinFlips(String[] board)
        {
            int rows = board.Length;
            int cols = board[0].Length;

            int[] dp = new int[cols];

            InitializeDP(board[rows - 1], dp);

            for (int i = rows - 2; i >= 0; i--)
            {
                int j = board[i].Length - 1;
                int cost = 0;
                int newCost = 0;

                while (j >= 0)
                {
                    if (board[i][j] == '0')
                    {
                        cost++;

                        newCost += Math.Abs(dp[j] + newCost - cost) % 2;

                        while (j >= 0 && board[i][j] == '0')
                        {
                            dp[j] = dp[j] + newCost;
                            j--;
                        }
                    }
                    else
                    {
                        if (j + 1 < cols && board[i][j + 1] == '0')
                            cost++;

                        newCost += Math.Abs(dp[j] + newCost - cost) % 2;

                        while (j >= 0 && board[i][j] == '1')
                        {
                            dp[j] = dp[j] + newCost;
                            j--;
                        }
                    }
                }
            }
            return dp[0];
        }
    }
}
