namespace Exercise1_SolutionUnitTest
{
    [TestClass]
    public class MysticAndCandiesEasyUnitTest
    {
        [TestMethod]
        public void minBoxes_TestCase0_ReturnsInt()
        {
            MysticAndCandiesEasy mysticAndCandiesEasy = new MysticAndCandiesEasy();
            int results = mysticAndCandiesEasy.minBoxes(10, 10, new int[] { 20 });
            int ans = 1;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void minBoxes_TestCase1_ReturnsInt()
        {
            MysticAndCandiesEasy mysticAndCandiesEasy = new MysticAndCandiesEasy();
            int results = mysticAndCandiesEasy.minBoxes(10, 7, new int[] { 3, 3, 3, 3, 3 });
            int ans = 4;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void minBoxes_TestCase2_ReturnsInt()
        {
            MysticAndCandiesEasy mysticAndCandiesEasy = new MysticAndCandiesEasy();
            int results = mysticAndCandiesEasy.minBoxes(100, 63, new int[] { 12, 34, 23, 45, 34 });
            int ans = 3;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void minBoxes_TestCase3_ReturnsInt()
        {
            MysticAndCandiesEasy mysticAndCandiesEasy = new MysticAndCandiesEasy();
            int results = mysticAndCandiesEasy.minBoxes(19, 12, new int[] { 12, 9, 15, 1, 6, 4, 9, 10, 10, 10, 14, 14, 1, 1, 12, 10, 9, 2, 3, 6, 1, 7, 3, 4, 10, 3, 14 });
            int ans = 22;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void minBoxes_TestCase4_ReturnsInt()
        {
            MysticAndCandiesEasy mysticAndCandiesEasy = new MysticAndCandiesEasy();
            int results = mysticAndCandiesEasy.minBoxes(326, 109, new int[] { 9, 13, 6, 6, 6, 16, 16, 16, 10, 16, 4, 3, 10, 8, 11, 17, 12, 5, 7, 8, 7, 4, 15, 7, 14, 2, 2, 1, 17, 1, 7, 7, 12, 17, 2, 9, 7, 1, 8, 16, 7, 4, 16, 2, 13, 3, 13, 1, 17, 6 });
            int ans = 15;
            Assert.AreEqual(ans, results);
        }
    }
}
