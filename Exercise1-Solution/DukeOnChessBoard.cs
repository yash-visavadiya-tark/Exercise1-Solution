using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class DukeOnChessBoard
    {
        private bool[,] InitializeGrid(int n, bool value)
        {
            bool[,] grid = new bool[n, n];
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    grid[i, j] = value;
                }
            }
            return grid;
        }

        private Dictionary<int, int> MapRows(int n)
        {
            Dictionary<int, int> rows = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                rows[i] = (n - i);
            }
            return rows;
        }

        private Dictionary<int, char> MapCols(int n)
        {
            Dictionary<int, char> cols = new Dictionary<int, char>();
            for (int i = 0; i < n; i++)
            {
                cols[i] = (char)(i + 97);
            }
            return cols;
        }

        private Queue<String> BuildFirst(Queue<String> first,Queue<String> last)
        {
            var ans = new Queue<string>();
            bool isLarge = first.Count + last.Count == 14;

            while (first.Count > 0)
            {
                string curr = first.Dequeue();
                if (first.Count == 0 && (isLarge || last.Count == 0))
                {
                    curr = curr.Substring(0, 2);
                }
                ans.Enqueue(curr);
            }

            if (last.Count == 7)
            {
                ans.Enqueue("...");
            }
            return ans;
        }

        private void AddLast(Queue<String> last, Queue<String> ans)
        {
            while (last.Count > 0)
            {
                string curr = last.Dequeue();
                if (last.Count == 0)
                {
                    curr = curr.Substring(0, 2);
                }
                ans.Enqueue(curr);
            }
        }
        
        private String ModifyAnswer(Queue<String> first, Queue<String> last)
        {
            var ans = BuildFirst(first, last);
            AddLast(last, ans);

            return String.Join("", ans);
        }

        public String DukePath(int n, String initPosition)
        {
            int i, j;
            bool[,] grid = InitializeGrid(n, value: false);
            Dictionary<int, int> row = MapRows(n);
            Dictionary<int, char> col = MapCols(n);

            Queue<String> first = new Queue<String>();
            Queue<String> last = new Queue<String>();
            
            // Initialization
            i = n - int.Parse(initPosition[1].ToString());
            j = initPosition[0] - 'a';

            grid[i, j] = true;
            first.Enqueue(initPosition + "-");

            // Main Part
            Dfs(i, j, n, first, last, grid, row, col);

            return ModifyAnswer(first, last);
        }

        public void Dfs(int i, int j, int n, Queue<String> first, Queue<String> last, bool[,] grid, Dictionary<int, int> row, Dictionary<int, char> col)
        {
            if (j + 1 < n && !grid[i, j + 1])
            {
                j++;
                // Add To Queue
                if (first.Count < 7)
                {
                    first.Enqueue(col[j] + "" + row[i].ToString() + "-");
                }
                else
                {
                    last.Enqueue(col[j] + "" + row[i].ToString() + "-");
                    while (last.Count > 7)
                    {
                        last.Dequeue();
                    }
                }
                grid[i, j] = true;
            }

            else if (i - 1 >= 0 && !grid[i - 1, j])
            {
                i--;
                // Add To Queue
                if (first.Count < 7)
                {
                    first.Enqueue(col[j] + "" + row[i].ToString() + "-");
                }
                else
                {
                    last.Enqueue(col[j] + "" + row[i].ToString() + "-");
                    while (last.Count > 7)
                    {
                        last.Dequeue();
                    }
                }
                grid[i, j] = true;
            }

            else if (i + 1 < n && !grid[i + 1, j])
            {
                i++;
                // Add To Queue
                if (first.Count < 7)
                {
                    first.Enqueue(col[j] + "" + row[i].ToString() + "-");
                }
                else
                {
                    last.Enqueue(col[j] + "" + row[i].ToString() + "-");
                    while (last.Count > 7)
                    {
                        last.Dequeue();
                    }
                }
                grid[i, j] = true;
                Dfs(i, j, n, first, last, grid, row, col);
            }

            else if (j - 1 >= 0 && !grid[i, j - 1])
            {
                j--;
                // Add To Queue
                if (first.Count < 7)
                {
                    first.Enqueue(col[j] + "" + row[i].ToString() + "-");
                }
                else
                {
                    last.Enqueue(col[j] + "" + row[i].ToString() + "-");
                    while (last.Count > 7)
                    {
                        last.Dequeue();
                    }
                }
                grid[i, j] = true;
            }

            else
            {
                return;
            }

            Dfs(i, j, n, first, last, grid, row, col);
        }
    }
}
