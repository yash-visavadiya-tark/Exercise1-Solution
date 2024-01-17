using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Solution
{
    public class WordCompositionGame
    {
        private int CalculateScoreForSinglePlayer(String[] currentPlayerScore, String[] Player1Score, String[] Player2Score)
        {
            int ans = 0;

            for (int i = 0; i < currentPlayerScore.Length; i++)
            {
                int cnt = 3;
                if (Player1Score.Contains(currentPlayerScore[i]))
                {
                    cnt--;
                }
                if (Player2Score.Contains(currentPlayerScore[i]))
                {
                    cnt--;
                }
                ans += cnt;
            }
            return ans;
        }

        public String Score(String[] listA, String[] listB, String[] listC)
        {
            int scoreA = CalculateScoreForSinglePlayer(currentPlayerScore: listA, Player1Score: listB, Player2Score: listC);
            int scoreB = CalculateScoreForSinglePlayer(currentPlayerScore: listB, Player1Score: listA, Player2Score: listC);
            int scoreC = CalculateScoreForSinglePlayer(currentPlayerScore: listC, Player1Score: listA, Player2Score: listB);

            return scoreA + "/" + scoreB + "/" + scoreC;
        }
    }
}
