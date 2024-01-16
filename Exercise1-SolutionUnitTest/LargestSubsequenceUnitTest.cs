using static System.Net.Mime.MediaTypeNames;

namespace Exercise1_SolutionUnitTest
{
    [TestClass]
    public class LargestSubsequenceUnitTest
    {
        [TestMethod]
        public void getLargest_TestCase0_ReturnsString()
        {
            LargestSubsequence largestSubsequence = new LargestSubsequence();
            String results = largestSubsequence.getLargest("test");
            String ans = "tt";
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void getLargest_TestCase1_ReturnsString()
        {
            LargestSubsequence largestSubsequence = new LargestSubsequence();
            String results = largestSubsequence.getLargest("a");
            String ans = "a";
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void getLargest_TestCase2_ReturnsString()
        {
            LargestSubsequence largestSubsequence = new LargestSubsequence();
            String results = largestSubsequence.getLargest("example");
            String ans = "xple";
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void getLargest_TestCase3_ReturnsString()
        {
            LargestSubsequence largestSubsequence = new LargestSubsequence();
            String results = largestSubsequence.getLargest("aquickbrownfoxjumpsoverthelazydog");
            String ans = "zyog";
            Assert.AreEqual(ans, results);
        }
    }
}
