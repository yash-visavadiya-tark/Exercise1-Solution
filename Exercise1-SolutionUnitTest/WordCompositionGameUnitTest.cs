using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1_SolutionUnitTest
{
    [TestClass]
    public class WordCompositionGameUnitTest
    {
        [TestMethod]
        public void Score_TestCase0_ReturnsString()
        {
            WordCompositionGame wordCompositionGame = new WordCompositionGame();
            String results = wordCompositionGame.Score(new string[] { "cat", "dog", "pig", "mouse" }, new String[] { "cat", "pig" }, new String[] { "dog", "cat" });
            String ans = "8/3/3";
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void Score_TestCase1_ReturnsString()
        {
            WordCompositionGame wordCompositionGame = new WordCompositionGame();
            String results = wordCompositionGame.Score(new string[] { "mouse" }, new String[] { "cat", "pig" }, new String[] { "dog", "cat" });
            String ans = "3/5/5";
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void Score_TestCase2_ReturnsString()
        {
            WordCompositionGame wordCompositionGame = new WordCompositionGame();
            String results = wordCompositionGame.Score(new string[] { "dog", "mouse" }, new String[] { "dog", "pig" }, new String[] { "dog", "cat" });
            String ans = "4/4/4";
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void Score_TestCase3_ReturnsString()
        {
            WordCompositionGame wordCompositionGame = new WordCompositionGame();
            String results = wordCompositionGame.Score(new string[] { "bcdbb", "aaccd", "dacbc", "bcbda", "cdedc", "bbaaa", "aecae" }, new String[] { "bcdbb", "ddacb", "aaccd", "adcab", "edbee", "aecae", "bcbda" }, new String[] { "dcaab", "aadbe", "bbaaa", "ebeec", "eaecb", "bcbba", "aecae", "adcab", "bcbda" });
            String ans = "14/14/21";
            Assert.AreEqual(ans, results);
        }
    }
}
