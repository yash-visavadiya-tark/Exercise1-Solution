using static System.Net.Mime.MediaTypeNames;

namespace Exercise1_SolutionUnitTest
{
    [TestClass]
    public class LargestSubsequenceUnitTest
    {
        [TestMethod]
        public void GetLargest_TestCase0_ReturnsString()
        {
            LargestSubsequence largestSubsequence = new LargestSubsequence();
            String results = largestSubsequence.GetLargest("test");
            String ans = "tt";
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void GetLargest_TestCase1_ReturnsString()
        {
            LargestSubsequence largestSubsequence = new LargestSubsequence();
            String results = largestSubsequence.GetLargest("a");
            String ans = "a";
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void GetLargest_TestCase2_ReturnsString()
        {
            LargestSubsequence largestSubsequence = new LargestSubsequence();
            String results = largestSubsequence.GetLargest("example");
            String ans = "xple";
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void GetLargest_TestCase3_ReturnsString()
        {
            LargestSubsequence largestSubsequence = new LargestSubsequence();
            String results = largestSubsequence.GetLargest("aquickbrownfoxjumpsoverthelazydog");
            String ans = "zyog";
            Assert.AreEqual(ans, results);
        }
    }
}
