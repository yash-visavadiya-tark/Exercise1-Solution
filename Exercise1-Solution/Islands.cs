namespace Exercise1_Solution
{
    public class Islands
    {
        private bool IsValidLeft(int i, int j, String[] kingdom)
        {
            return j - 1 >= 0;
        }

        private bool IsValidRight(int i, int j, String[] kingdom)
        {
            return j + 1 < kingdom[i].Length;
        }

        private bool IsValidTop(int i, int j, String[] kingdom)
        {
            return i - 1 >= 0 && j < kingdom[i - 1].Length;
        }

        private bool IsValidBottom(int i, int j, String[] kingdom)
        {
            return i + 1 < kingdom.Length && j < kingdom[i + 1].Length;
        }

        private bool IsValidTopLeft(int i, int j, String[] kingdom)
        {
            return i - 1 >= 0 && j - 1 >= 0;
        }

        private bool IsValidBottomLeft(int i, int j, String[] kingdom)
        {
            return i + 1 < kingdom.Length && j - 1 >= 0;
        }

        private bool IsValidTopRight(int i, int j, String[] kingdom)
        {
            return i - 1 >= 0 && j + 1 < kingdom[i - 1].Length;
        }

        private bool IsValidBottomRight(int i, int j, String[] kingdom)
        {
            return i + 1 < kingdom.Length && j + 1 < kingdom[i + 1].Length;
        }

        public int BeachLength(String[] kingdom)
        {
            int beachCount = 0;
            
            for (int i = 0; i < kingdom.Length; i++)
            {
                for (int j = 0; j < kingdom[i].Length; j++)
                {
                    if (kingdom[i][j] == '#')
                    {
                        if (IsValidLeft(i, j, kingdom) && kingdom[i][j - 1] == '.')
                            beachCount++;
                        if (IsValidRight(i, j , kingdom) && kingdom[i][j + 1] == '.')
                            beachCount++;


                        if (IsValidTop(i, j, kingdom) && kingdom[i - 1][j] == '.')
                            beachCount++;
                        if (IsValidBottom(i, j, kingdom) && kingdom[i + 1][j] == '.')
                            beachCount++;

                        if (i % 2 == 0)
                        {
                            if (IsValidTopLeft(i, j, kingdom) && kingdom[i - 1][j - 1] == '.')
                                beachCount++;
                            if (IsValidBottomLeft(i, j, kingdom) && kingdom[i + 1][j - 1] == '.')
                                beachCount++;
                        }
                        else
                        {
                            if (IsValidTopRight(i, j, kingdom) && kingdom[i - 1][j + 1] == '.')
                                beachCount++;
                            if (IsValidBottomRight(i, j, kingdom) && kingdom[i + 1][j + 1] == '.')
                                beachCount++;
                        }
                    }
                }
            }
            return beachCount;
        }
    }
}
