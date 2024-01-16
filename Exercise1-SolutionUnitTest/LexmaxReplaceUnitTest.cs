namespace Exercise1_SolutionUnitTest
{
    [TestClass]
    public class LexmaxReplaceUnitTest
    {
        [TestMethod]
        public void get_TestCase0_ReturnsString()
        {
            string s = "abb";
            string t = "c";
            string ans = "cbb";
            LexmaxReplace lexmaxReplace = new LexmaxReplace();
            string results = lexmaxReplace.get(s, t);
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void get_TestCase1_ReturnsString()
        {
            String s = "z";
            String t = "f";
            String ans = "z";
            LexmaxReplace lexmaxReplace = new LexmaxReplace();
            String results = lexmaxReplace.get(s, t);
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void get_TestCase2_ReturnsString()
        {
            String s = "fedcba";
            String t = "ee";
            String ans = "feeeba";
            LexmaxReplace lexmaxReplace = new LexmaxReplace();
            String results = lexmaxReplace.get(s, t);
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void get_TestCase3_ReturnsString()
        {
            String s = "top";
            String t = "coder";
            String ans = "trp";
            LexmaxReplace lexmaxReplace = new LexmaxReplace();
            String results = lexmaxReplace.get(s, t);
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void get_TestCase4_ReturnsString()
        {
            String s = "xldyzmsrrwzwaofkcxwehgvtrsximxgdqrhjthkgfucrjdvwlr";
            String t = "xfpidmmilhdfzypbguentqcojivertdhshstkcysydgcwuwhlk";
            String ans = "zyyyzyxwwwzwvuuttxwtssvtssxrqxppqrontmmllukrkjvwlr";
            LexmaxReplace lexmaxReplace = new LexmaxReplace();
            String results = lexmaxReplace.get(s, t);
            Assert.AreEqual(ans, results);
        }
    }
}
