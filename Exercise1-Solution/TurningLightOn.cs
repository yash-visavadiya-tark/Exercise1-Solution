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

            int[] colOperations = new int[cols];
            char[] changedRow = new char[cols];
            
            InitializeDP(board[rows - 1], colOperations);

            int i = rows - 2;
            while ( i >= 0)
            {
                int j = cols - 1;
                int additionalOperationInRow = 0;
                while (j >= 0)
                {
                    changedRow[j] = board[i][j];
                    int currentOperation = colOperations[j] + additionalOperationInRow; 
                    if (currentOperation % 2 == 1)
                    {
                        if (changedRow[j] == '1')
                            changedRow[j] = '0';
                        else
                            changedRow[j] = '1';
                    }

                    if (changedRow[j] == '1')
                    {
                        colOperations[j] = colOperations[j] + additionalOperationInRow;
                    }
                    else
                    {
                        additionalOperationInRow++;
                        colOperations[j] = colOperations[j] + additionalOperationInRow;
                    }
                    j--;
                }
                i--;
            }
            return colOperations[0];
        }

        private void print1D(int[] arr) {
            foreach (int k in arr)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
        }
    }
}
