namespace Exercise1_SolutionUnitTest
{
    [TestClass]
    public class SortingSubsetsUnitTest
    {
        [TestMethod]
        public void getMinimalSize_TestCase0_ReturnsInt()
        {
            SortingSubsets sortingSubsets = new SortingSubsets();
            int results = sortingSubsets.getMinimalSize(new int[] { 3, 2, 1 });
            int ans = 2;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void getMinimalSize_TestCase1_ReturnsInt()
        {
            SortingSubsets sortingSubsets = new SortingSubsets();
            int results = sortingSubsets.getMinimalSize(new int[] { 1, 2, 3, 4 });
            int ans = 0;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void getMinimalSize_TestCase2_ReturnsInt()
        {
            SortingSubsets sortingSubsets = new SortingSubsets();
            int results = sortingSubsets.getMinimalSize(new int[] { 4, 4, 4, 3, 3, 3 });
            int ans = 6;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void getMinimalSize_TestCase3_ReturnsInt()
        {
            SortingSubsets sortingSubsets = new SortingSubsets();
            int results = sortingSubsets.getMinimalSize(new int[] { 11, 11, 49, 7, 11, 11, 7, 7, 11, 49, 11 });
            int ans = 7;
            Assert.AreEqual(ans, results);
        }
    }
}
