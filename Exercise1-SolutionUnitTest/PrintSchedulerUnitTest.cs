namespace Exercise1_SolutionUnitTest
{
    [TestClass]
    public class PrintSchedulerUnitTest
    {
        [TestMethod]
        public void GetOutput_TestCase0_ReturnsString()
        {
            PrintScheduler scheduler = new PrintScheduler();
            String results = scheduler.GetOutput(new string[] { "AB", "CD" }, new String[] { "0 1", "1 1", "0 1", "1 2" });
            String ans = "ACBDC";
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void GetOutput_TestCase1_ReturnsString()
        {
            PrintScheduler scheduler = new PrintScheduler();
            String results = scheduler.GetOutput(new string[] { "ABCDE" }, new String[] { "0 20", "0 21" });
            String ans = "ABCDEABCDEABCDEABCDEABCDEABCDEABCDEABCDEA";
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void GetOutput_TestCase2_ReturnsString()
        {
            PrintScheduler scheduler = new PrintScheduler();
            String results = scheduler.GetOutput(new string[] { "A", "B" }, new String[] { "1 10", "0 1", "1 10", "0 2" });
            String ans = "BBBBBBBBBBABBBBBBBBBBAA";
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void GetOutput_TestCase3_ReturnsString()
        {
            PrintScheduler scheduler = new PrintScheduler();
            String results = scheduler.GetOutput(new string[] { "A" }, new String[] { "0 1"});
            String ans = "A";
            Assert.AreEqual(ans, results);
        }
    }
}
