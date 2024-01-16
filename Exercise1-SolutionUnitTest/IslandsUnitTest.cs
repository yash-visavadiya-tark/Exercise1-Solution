namespace Exercise1_SolutionUnitTest
{
    [TestClass]
    public class IslandsUnitTest
    {
        [TestMethod]
        public void beachLength_TestCase0_ReturnsInt()
        {
            Islands islands = new Islands();
            int results = islands.beachLength(new String[] { ".#...#.." });
            int ans = 4;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void beachLength_TestCase1_ReturnsInt()
        {
            Islands islands = new Islands();
            int results = islands.beachLength(new String[] { "..#.##", ".##.#.", "#.#..." });
            int ans = 19;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void beachLength_TestCase2_ReturnsInt()
        {
            Islands islands = new Islands();
            int results = islands.beachLength(new String[] { "#...#.....", "##..#...#." });
            int ans = 15;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void beachLength_TestCase3_ReturnsInt()
        {
            Islands islands = new Islands();
            int results = islands.beachLength(new String[] { "....#.", ".#....", "..#..#", "####.." });
            int ans = 24;
            Assert.AreEqual(ans, results);
        }
    }
}
