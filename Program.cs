using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Exercise1_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HuffmanDecoding huffmanDecoding = new HuffmanDecoding();

            //String archive = "001101100101100110111101011001011001010";
            //String[] dictionary = { "110", "011", "10", "0011", "00011", "111", "00010", "0010", "010", "0000" };

            //Console.WriteLine(huffmanDecoding.decode(archive, dictionary));


            //LexmaxReplace lexmaxReplace = new LexmaxReplace();

            //String s = "xldyzmsrrwzwaofkcxwehgvtrsximxgdqrhjthkgfucrjdvwlr";
            //String t = "xfpidmmilhdfzypbguentqcojivertdhshstkcysydgcwuwhlk";

            //Console.WriteLine(lexmaxReplace.get(s, t));


            //SortingSubsets sortingSubsets = new SortingSubsets();
            //int[] a = { 11, 11, 49, 7, 11, 11, 7, 7, 11, 49, 11 };
            //Console.WriteLine(sortingSubsets.getMinimalSize(a));


            //PalindromeDecoding palindromeDecoding = new PalindromeDecoding();
            //String code = "TC206";
            //int[] position = { 1, 2, 5 };
            //int[] length = { 1, 1, 1 };
            //Console.WriteLine(palindromeDecoding.decode(code, position, length));


            //MovingAvg movingAvg = new MovingAvg();
            //int k = 3;
            //double[] data = { 6, 2.5, 3.5 };
            //Console.WriteLine(movingAvg.difference(k, data));


            //WordCompositionGame wordCompositionGame = new WordCompositionGame();
            //String[] listA = { "bcdbb", "aaccd", "dacbc", "bcbda", "cdedc", "bbaaa", "aecae" };
            //String[] listB = { "bcdbb", "ddacb", "aaccd", "adcab", "edbee", "aecae", "bcbda" };
            //String[] listC = { "dcaab", "aadbe", "bbaaa", "ebeec", "eaecb", "bcbba", "aecae", "adcab", "bcbda" };
            //Console.WriteLine(wordCompositionGame.score(listA, listB, listC));


            //LargestSubsequence largestSubsequence   = new LargestSubsequence();
            //String s = "gfdcbazyx";
            //Console.WriteLine(largestSubsequence.getLargest(s));


            //MaximumBalances maximumBalances = new MaximumBalances();
            //String s = "))()()))(()";
            //Console.WriteLine(maximumBalances.solve(s));


            //DukeOnChessBoard dukeOnChessBoard = new DukeOnChessBoard();
            //int n = 4;
            //String initPosition = "d3";
            //Console.WriteLine(dukeOnChessBoard.dukePath(n, initPosition));


            //Islands islands = new Islands();
            //String[] kingdom = { "....#.", ".#....", "..#..#", "####.." };
            //Console.WriteLine(islands.beachLength(kingdom));


            //Mailbox mailbox = new Mailbox();
            //String collection = "ABCDAAST";
            //String[] address = { "111 A ST", "A BAD ST", "B BAD ST" };
            //Console.WriteLine(mailbox.impossible(collection, address));


            //MysticAndCandiesEasy mysticAndCandiesEasy = new MysticAndCandiesEasy();
            //int C = 100;
            //int X = 1;
            //int[] high = { 12, 23, 34, 34, 45 };
            //Console.WriteLine(mysticAndCandiesEasy.minBoxes(C, X, high));


            //PrintScheduler printScheduler = new PrintScheduler();
            //String[] threads = { "A" };
            //String[] slices = { "0 1" };
            //Console.WriteLine(printScheduler.getOutput(threads, slices));


            TurningLightOn turningLightOn = new TurningLightOn();
            String[] board = { "0101", "1010", "0101", "1010" };
            Console.WriteLine(turningLightOn.minFlips(board));
        }
    }

    #region HuffmanDecoding Problem-1
    class HuffmanDecoding
    {
        public String decode(String archive, string[] dictionary)
        {
            int i = 0;
            int s1 = archive.Length;
            int s2 = dictionary.Length;

            String ans = "";
            while (i < s1)
            {
                for (int j = 0; j < s2; j++)
                {
                    int len = dictionary[j].Length;
                    bool flag = true;

                    if (i >= s1)
                    {
                        break;
                    }
                    for (int k = i; k < i + len; k++)
                    {
                        if (archive[k] != dictionary[j][k - i])
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        ans += (char)(j + 65);
                        i += len;

                    }
                }
            }
            return ans;
        }
    }
    #endregion

    #region LexmaxReplace Problem-2
    class LexmaxReplace
    {
        public String get(String s, String t)
        {
            String ans = "";
            char[] arr = t.ToCharArray();
            Array.Sort(arr, new Comparison<char>((c1, c2) => c2.CompareTo(c1)));

            t = new String(arr);

            int i = 0, j = 0;
            while (i < s.Length && j < t.Length)
            {
                if (s[i] > t[j])
                {
                    ans += s[i];
                    i++;
                }
                else
                {
                    ans += t[j];
                    i++;
                    j++;
                }
            }
            while (i < s.Length)
            {
                ans += s[i];
            }

            return ans;
        }
    }
    #endregion

    #region SortingSubsets Problem-3
    class SortingSubsets
    {
        public int getMinimalSize(int[] a)
        {
            int ans = 0;
            int[] arr = new int[a.Length];
            a.CopyTo(arr, 0);
            Array.Sort(a);

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
    #endregion

    #region PalindromeDecoding Problem-4
    class PalindromeDecoding
    {
        public String decode(String code, int[] position, int[] length)
        {
            StringBuilder ans = new StringBuilder(code);

            for (int i = 0; i < position.Length; i++)
            {
                StringBuilder palindrome = new StringBuilder("");
                for (int j = position[i]; j < position[i] + length[i]; j++)
                {
                    palindrome.Append(ans[j]);
                }

                for (int j = 0; j < palindrome.Length / 2; j++)
                {
                    char copy = palindrome[j];
                    palindrome[j] = palindrome[palindrome.Length - 1 - j];
                    palindrome[palindrome.Length - 1 - j] = copy;
                }

                ans.Insert(position[i] + length[i], palindrome.ToString());

            }
            return ans.ToString();
        }
    }
    #endregion

    #region MovingAvg Problem-5
    class MovingAvg
    {
        public double difference(int k, double[] data)
        {
            double maxi = 0;
            double mini = 0;

            double sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += data[i];
            }

            maxi = sum / k;
            mini = sum / k;

            for (int i = k; i < data.Length; i++)
            {
                sum += data[i] - data[i - k];

                maxi = Math.Max(maxi, sum / k);
                mini = Math.Min(mini, sum / k);
            }

            return maxi - mini;
        }
    }
    #endregion

    #region WordCompositionGame Problem-6
    class WordCompositionGame
    {
        public String score(String[] listA, String[] listB, String[] listC)
        {
            int scoreA = 0;
            int scoreB = 0;
            int scoreC = 0;

            for (int i = 0; i < listA.Length; i++)
            {
                int cnt = 3;
                if (listB.Contains(listA[i]))
                {
                    cnt--;
                }
                if (listC.Contains(listA[i]))
                {
                    cnt--;
                }

                scoreA += cnt;
            }

            for (int i = 0; i < listB.Length; i++)
            {
                int cnt = 3;
                if (listA.Contains(listB[i]))
                {
                    cnt--;
                }
                if (listC.Contains(listB[i]))
                {
                    cnt--;
                }

                scoreB += cnt;
            }

            for (int i = 0; i < listC.Length; i++)
            {
                int cnt = 3;
                if (listA.Contains(listC[i]))
                {
                    cnt--;
                }
                if (listB.Contains(listC[i]))
                {
                    cnt--;
                }

                scoreC += cnt;
            }
            return scoreA + "/" + scoreB + "/" + scoreC;
        }
    }
    #endregion

    #region LargestSubsequence Problem-7
    class LargestSubsequence
    {
        public String getLargest(String s)
        {
            string ans = "";
            int n = s.Length;
            Stack<char> st = new Stack<char>();

            int i = 0;
            while (i < n)
            {
                while (st.Count > 0 && st.Peek().CompareTo(s[i]) < 0)
                {
                    st.Pop();
                }
                st.Push(s[i]);
                i++;
            }

            while (st.Count > 0)
            {
                ans += st.Pop();
            }

            return new string(ans.Reverse().ToArray());
        }
    }
    #endregion

    #region MaximumBalances Problem-8
    class MaximumBalances
    {
        public int solve(String s)
        {
            int ans = 0;
            int openingBracketCount = 0;
            int closingBracketCount = 0;

            foreach (char c in s)
            {
                if (c == '(')
                    openingBracketCount++;
                else
                    closingBracketCount++;
            }

            ans = Math.Min(openingBracketCount, closingBracketCount);
            return ans * (ans + 1) / 2;
        }
    }
    #endregion

    #region DukeOnChessBoard Problem-9
    class DukeOnChessBoard
    {
        public String dukePath(int n, String initPosition)
        {
            bool[,] grid = new bool[n, n];
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    grid[i, j] = false;
                }
            }

            Dictionary<int, int> row = new Dictionary<int, int>();
            for (i = 0; i < n; i++)
            {
                row[i] = (n - i);
            }

            Dictionary<int, char> col = new Dictionary<int, char>();
            for (i = 0; i < n; i++)
            {
                col[i] = (char)(i + 97);
            }

            Queue<String> first = new Queue<String>();
            Queue<String> last = new Queue<String>();
            Queue<String> ans = new Queue<string>();

            i = n - Int32.Parse(initPosition[1].ToString());
            j = initPosition[0] - 'a';

            grid[i, j] = true;
            first.Enqueue(initPosition + "-");

            // Main Part
            dfs(i, j, n, first, last, grid, row, col);

            bool isLarge = first.Count + last.Count == 14;
            while (first.Count > 0)
            {
                string curr = first.Dequeue();
                if (first.Count == 0 && isLarge)
                {
                    curr = curr.Substring(0, 2);
                }
                ans.Enqueue(curr);
            }

            if (last.Count == 7)
            {
                ans.Enqueue("...");
            }
            while (last.Count > 0)
            {
                string curr = last.Dequeue();
                if (last.Count == 0)
                {
                    curr = curr.Substring(0, 2);
                }
                ans.Enqueue(curr);
            }
            return String.Join("", ans);
        }

        public void dfs(int i, int j, int n, Queue<String> first, Queue<String> last, bool[,] grid, Dictionary<int, int> row, Dictionary<int, char> col)
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
                //Console.WriteLine(i + " " + j);
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
                dfs(i, j, n, first, last, grid, row, col);
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

            dfs(i, j, n, first, last, grid, row, col);
        }
    }
    #endregion

    #region Islands Problem-10
    class Islands
    {
        public int beachLength(String[] kingdom)
        {
            int ans = 0;
            int n = kingdom.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < kingdom[i].Length; j++)
                {
                    int prev = ans;
                    if (kingdom[i][j] == '#')
                    {
                        if (j - 1 >= 0 && kingdom[i][j - 1] == '.')
                            ans++;
                        if (j + 1 < kingdom[i].Length && kingdom[i][j + 1] == '.')
                            ans++;


                        if (i - 1 >= 0 && j < kingdom[i - 1].Length && kingdom[i - 1][j] == '.')
                            ans++;
                        if (i + 1 < n && j < kingdom[i + 1].Length && kingdom[i + 1][j] == '.')
                            ans++;

                        if (i % 2 == 0)
                        {
                            if (i - 1 >= 0 && j - 1 >= 0 && kingdom[i - 1][j - 1] == '.')
                                ans++;
                            if (i + 1 < n && j - 1 >= 0 && kingdom[i + 1][j - 1] == '.')
                                ans++;
                        }
                        else
                        {
                            if (i - 1 >= 0 && j + 1 < kingdom[i - 1].Length && kingdom[i - 1][j + 1] == '.')
                                ans++;
                            if (i + 1 < n && j + 1 < kingdom[i + 1].Length && kingdom[i + 1][j + 1] == '.')
                                ans++;
                        }
                    }

                }
            }
            return ans;
        }
    }
    #endregion

    #region Mailbox Problem-11
    class Mailbox
    {
        public int impossible(String collection, String[] address)
        {
            int ans = 0;
            Dictionary<char, int> collectionCount = new Dictionary<char, int>();

            foreach (char ch in collection)
            {
                if (collectionCount.Keys.Contains(ch))
                    collectionCount[ch]++;
                else
                    collectionCount[ch] = 1;
            }

            foreach (String s in address)
            {

                Dictionary<char, int> currentCount = new Dictionary<char, int>();
                foreach (char ch in s)
                {
                    if (ch == ' ')
                        continue;

                    if (currentCount.Keys.Contains(ch))
                        currentCount[ch]++;
                    else
                        currentCount[ch] = 1;
                }

                foreach (char ch in currentCount.Keys)
                {
                    if (!(collectionCount.ContainsKey(ch) && collectionCount[ch] >= currentCount[ch]))
                    {
                        ans++;
                        break;
                    }
                }
            }

            return ans;
        }
    }
    #endregion

    #region MysticAndCandiesEasy Problem-12
    class MysticAndCandiesEasy
    {
        public int minBoxes(int C, int X, int[] high)
        {
            int[] arr = high.OrderByDescending(c => c).ToArray();

            int ans = 0;
            int s = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                s += arr[i];
                if (C - s <= 0)
                {
                    s -= arr[i];
                    arr[i] = C - s;
                    s += C - s;
                }
            }

            s = 0;
            foreach (int n in arr)
            {
                if (s < X)
                {
                    ans++;
                }
                s += n;
            }

            return ans;
        }
    }
    #endregion

    #region PrintScheduler Problem-13
    class PrintScheduler
    {
        public String getOutput(String[] threads, String[] slices)
        {
            String ans = "";
            Dictionary<int, int> mapInd = new Dictionary<int, int>();
            int i;
            for (i = 0; i < threads.Length; i++)
            {
                mapInd[i] = 0;
            }

            for(i = 0; i < slices.Length; i++)
            {
                String[] slice = slices[i].Split(' ');
                int ind = Int32.Parse(slice[0]);
                int time = Int32.Parse(slice[1]);
                while (time > 0)
                {
                    ans += threads[ind][mapInd[ind]];
                    mapInd[ind] ++;
                    time--;
                    if (mapInd[ind] == threads[ind].Length)
                    {
                        mapInd[ind] = 0;
                    }
                }
            }
            return ans;
        }
    }
    #endregion

    #region TurningLightOn Problem-14
    class TurningLightOn
    {
        public void swapStates(int r, int c, String[] board)
        {
            for(int i = 0; i <= r; i++)
            {
                char[] cur = board[i].ToCharArray();
                for(int j = 0; j <= c; j++)
                {
                    if (cur[j] == '1') cur[j] = '0';
                    else cur[j] = '1';
                }
                board[i] = String.Join("", cur);
            }
        }
        public void printBoard(String[] board)
        {
            foreach (var s in board)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }
        public int minFlips(String[] board)
        {
            int rows = board.Length;
            int cols = board[0].Length;

            int ans = 0;

            for(int i = rows - 1; i >= 0; i--)
            {
                for(int j = board[i].Length - 1; j >= 0; j--)
                {
                    if (board[i][j] == '0')
                    {
                        swapStates(i, j, board);
                        ans++;
                    }
                }
            }
            return ans;
        }
    }
    #endregion
}
