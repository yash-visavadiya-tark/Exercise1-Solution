namespace Exercise1_SolutionUnitTest
{
    [TestClass]
    public class TurningLightOnUnitTest
    {
        [TestMethod]
        public void MinFlips_TestCase0_ReturnsInt()
        {
            TurningLightOn turningLightOn = new TurningLightOn();
            int results = turningLightOn.MinFlips(new string[] { "0001111", "0001111", "1111111" });
            int ans = 1;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void MinFlips_TestCase1_ReturnsInt()
        {
            TurningLightOn turningLightOn = new TurningLightOn();
            int results = turningLightOn.MinFlips(new string[] { "1111111", "1111111", "1111111" });
            int ans = 0;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void MinFlips_TestCase2_ReturnsInt()
        {
            TurningLightOn turningLightOn = new TurningLightOn();
            int results = turningLightOn.MinFlips(new string[] { "01001" });
            int ans = 3;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void MinFlips_TestCase3_ReturnsInt()
        {
            TurningLightOn turningLightOn = new TurningLightOn();
            int results = turningLightOn.MinFlips(new string[] { "0101", "1010", "0101", "1010" });
            int ans = 7;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void MinFlips_TestCase4_ReturnsInt()
        {
            TurningLightOn turningLightOn = new TurningLightOn();
            int results = turningLightOn.MinFlips(new string[] { "1111", "1010", "1111", "1010" });
            int ans = 16;
            Assert.AreEqual(ans, results);
        }
    }
}
