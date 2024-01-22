using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class DukeOnChessBoard
    {
        private Queue<String> BuildFirst(Queue<String> first, Queue<String> last)
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
            List<List<bool>> grid = Enumerable.Range(0, n).
                                    Select(row => Enumerable.Range(0, n).
                                        Select(col => false).ToList()).ToList();

            Dictionary<int, int> row = Enumerable.Range(0, n).
                                        ToDictionary(Key => Key, value => n - value);

            int asciiValue = 97;
            Dictionary<int, char> col = Enumerable.Range(0, n).
                                        ToDictionary(key => key, value => (char)(value + asciiValue));

            Queue<String> first = new Queue<String>();
            Queue<String> last = new Queue<String>();

            int i = n - int.Parse(initPosition[1].ToString());
            int j = initPosition[0] - 'a';

            grid[i][j] = true;
            first.Enqueue(initPosition + "-");

            Dfs(i, j, n, first, last, grid, row, col);

            return ModifyAnswer(first, last);
        }

        public void Dfs(int i, int j, int n, Queue<String> first, Queue<String> last, List<List<bool>> grid, Dictionary<int, int> row, Dictionary<int, char> col)
        {
            if (j + 1 < n && !grid[i][j + 1])
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
                grid[i][j] = true;
            }

            else if (i - 1 >= 0 && !grid[i - 1][j])
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
                grid[i][j] = true;
            }

            else if (i + 1 < n && !grid[i + 1][j])
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
                grid[i][j] = true;
                Dfs(i, j, n, first, last, grid, row, col);
            }

            else if (j - 1 >= 0 && !grid[i][j - 1])
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
                grid[i][j] = true;
            }

            else
            {
                return;
            }

            Dfs(i, j, n, first, last, grid, row, col);
        }
    }
}
