using System.Text;

namespace Exercise1_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HuffmanDecoding Problem-1

            //HuffmanDecoding huffmanDecoding = new HuffmanDecoding();

            //String archive = "001101100101100110111101011001011001010";
            //String[] dictionary = { "110", "011", "10", "0011", "00011", "111", "00010", "0010", "010", "0000" };

            //Console.WriteLine(huffmanDecoding.Decode(archive, dictionary));

            #endregion

            #region LexmaxReplace Problem-2

            //LexmaxReplace lexmaxReplace = new LexmaxReplace();

            //String s = "xldyzmsrrwzwaofkcxwehgvtrsximxgdqrhjthkgfucrjdvwlr";
            //String t = "xfpidmmilhdfzypbguentqcojivertdhshstkcysydgcwuwhlk";

            //Console.WriteLine(lexmaxReplace.Get(s, t));

            #endregion

            #region SortingSubsets Problem-3

            //SortingSubsets sortingSubsets = new SortingSubsets();
            //int[] a = { 11, 11, 49, 7, 11, 11, 7, 7, 11, 49, 11 };
            //Console.WriteLine(sortingSubsets.GetMinimalSize(a));

            #endregion

            #region PalindromeDecoding Problem-4

            //PalindromeDecoding palindromeDecoding = new PalindromeDecoding();
            //String code = "TC206";
            //int[] position = { 1, 2, 5 };
            //int[] length = { 1, 1, 1 };
            //Console.WriteLine(palindromeDecoding.Decode(code, position, length));

            #endregion

            #region MovingAvg Problem-5

            //MovingAvg movingAvg = new MovingAvg();
            //int k = 3;
            //double[] data = { 6, 2.5, 3.5 };
            //Console.WriteLine(movingAvg.Difference(k, data));

            #endregion

            #region WordCompositionGame Problem-6

            //WordCompositionGame wordCompositionGame = new WordCompositionGame();
            //String[] listA = { "bcdbb", "aaccd", "dacbc", "bcbda", "cdedc", "bbaaa", "aecae" };
            //String[] listB = { "bcdbb", "ddacb", "aaccd", "adcab", "edbee", "aecae", "bcbda" };
            //String[] listC = { "dcaab", "aadbe", "bbaaa", "ebeec", "eaecb", "bcbba", "aecae", "adcab", "bcbda" };
            //Console.WriteLine(wordCompositionGame.Score(listA, listB, listC));

            #endregion

            #region LargestSubsequence Problem-7

            //LargestSubsequence largestSubsequence   = new LargestSubsequence();
            //String s = "gfdcbazyx";
            //Console.WriteLine(largestSubsequence.GetLargest(s));

            #endregion

            #region MaximumBalances Problem-8

            //MaximumBalances maximumBalances = new MaximumBalances();
            //String s = "))()()))(()";
            //Console.WriteLine(maximumBalances.Solve(s));

            #endregion

            #region DukeOnChessBoard Problem-9

            //DukeOnChessBoard dukeOnChessBoard = new DukeOnChessBoard();
            //int n = 4;
            //String initPosition = "d3";
            //Console.WriteLine(dukeOnChessBoard.DukePath(n, initPosition));

            #endregion

            #region Islands Problem-10

            //Islands islands = new Islands();
            //String[] kingdom = { "....#.", ".#....", "..#..#", "####.." };
            //Console.WriteLine(islands.BeachLength(kingdom));

            #endregion

            #region Mailbox Problem-11

            //Mailbox mailbox = new Mailbox();
            //String collection = "ABCDAAST";
            //String[] address = { "111 A ST", "A BAD ST", "B BAD ST" };
            //Console.WriteLine(mailbox.Impossible(collection, address));

            #endregion

            #region MysticAndCandiesEasy Problem-12

            //MysticAndCandiesEasy mysticAndCandiesEasy = new MysticAndCandiesEasy();
            //int C = 100;
            //int X = 1;
            //int[] high = { 12, 23, 34, 34, 45 };
            //Console.WriteLine(mysticAndCandiesEasy.MinBoxes(C, X, high));

            #endregion

            #region PrintScheduler Problem-13

            //PrintScheduler printScheduler = new PrintScheduler();
            //String[] threads = { "A" };
            //String[] slices = { "0 1" };
            //Console.WriteLine(printScheduler.GetOutput(threads, slices));

            #endregion

            #region TurningLightOn Problem-14

            TurningLightOn turningLightOn = new TurningLightOn();
            String[] board = { "0101", "1010", "0101", "1010" };
            Console.WriteLine(turningLightOn.MinFlips(board));

            #endregion
        }
    }
}
