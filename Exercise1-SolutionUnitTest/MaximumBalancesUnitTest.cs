namespace Exercise1_SolutionUnitTest
{
    [TestClass]
    public class MaximumBalancesUnitTest
    {
        [TestMethod]
        public void solve_TestCase0_ReturnsInt()
        {
            MaximumBalances maximumBalances = new MaximumBalances();
            int results = maximumBalances.solve("((((");
            int ans = 0;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void solve_TestCase1_ReturnsInt()
        {
            MaximumBalances maximumBalances = new MaximumBalances();
            int results = maximumBalances.solve("(())");
            int ans = 3;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void solve_TestCase2_ReturnsInt()
        {
            MaximumBalances maximumBalances = new MaximumBalances();
            int results = maximumBalances.solve(")))())");
            int ans = 1;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void solve_TestCase3_ReturnsInt()
        {
            MaximumBalances maximumBalances = new MaximumBalances();
            int results = maximumBalances.solve("))()()))(()");
            int ans = 10;
            Assert.AreEqual(ans, results);
        }
    }
}
