namespace Exercise1_SolutionUnitTest
{
    [TestClass]
    public class MovingAvgUnitTest
    {
        [TestMethod]
        public void Difference_TestCase0_ReturnsDouble()
        {
            MovingAvg movingAvg = new MovingAvg();
            double results = movingAvg.Difference(2, new double[] { 3, 8, 9, 15 });
            double ans = 6.5;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void Difference_TestCase1_ReturnsDouble()
        {
            MovingAvg movingAvg = new MovingAvg();
            double results = movingAvg.Difference(3, new double[] { 17, 6.2, 19, 3.4 });
            double ans = 4.533333333333335;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void Difference_TestCase2_ReturnsDouble()
        {
            MovingAvg movingAvg = new MovingAvg();
            double results = movingAvg.Difference(3, new double[] { 6, 2.5, 3.5 });
            double ans = 0;
            Assert.AreEqual(ans, results);
        }
    }
}
