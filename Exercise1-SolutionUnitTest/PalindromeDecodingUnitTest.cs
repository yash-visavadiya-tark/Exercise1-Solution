namespace Exercise1_SolutionUnitTest
{
    [TestClass]
    public class PalindromeDecodingUnitTest
    {
        [TestMethod]
        public void Decode_TestCase0_ReturnsString()
        {
            PalindromeDecoding palindromeDecoding = new PalindromeDecoding();
            String results = palindromeDecoding.Decode("ab", new int[] { 0 }, new int[] { 2 });
            String ans = "abba";
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void Decode_TestCase1_ReturnsString()
        {
            PalindromeDecoding palindromeDecoding = new PalindromeDecoding();
            String results = palindromeDecoding.Decode("Misip", new int[] { 2, 3, 1, 7 }, new int[] { 1, 1, 2, 2 });
            String ans = "Mississippi";
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void Decode_TestCase2_ReturnsString()
        {
            PalindromeDecoding palindromeDecoding = new PalindromeDecoding();
            String results = palindromeDecoding.Decode("XY", new int[] { 0, 0, 0, 0 }, new int[] { 2, 4, 8, 16 });
            String ans = "XYYXXYYXXYYXXYYXXYYXXYYXXYYXXYYX";
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void Decode_TestCase3_ReturnsString()
        {
            PalindromeDecoding palindromeDecoding = new PalindromeDecoding();
            String results = palindromeDecoding.Decode("TC206", new int[] { 1, 2, 5 }, new int[] { 1, 1, 1 });
            String ans = "TCCC2006";
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void Decode_TestCase4_ReturnsString()
        {
            PalindromeDecoding palindromeDecoding = new PalindromeDecoding();
            String results = palindromeDecoding.Decode("nodecoding", new int[] { }, new int[] { });
            String ans = "nodecoding";
            Assert.AreEqual(ans, results);
        }
    }
}
