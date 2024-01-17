namespace Exercise1_Solution
{
    public class Islands
    {
        public int BeachLength(String[] kingdom)
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
}
