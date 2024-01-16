namespace Exercise1_SolutionUnitTest
{
    [TestClass]
    public class DukeOnChessBoardUnitTest
    {
        [TestMethod]
        public void dukePath_TestCase0_ReturnsString()
        {
            DukeOnChessBoard dukeOnChessBoard = new DukeOnChessBoard();
            String results = dukeOnChessBoard.dukePath(3, "b2");
            String ans = "b2-c2-c3-b3-a3-a2-a1-b1-c1";
            Assert.AreEqual(ans, results);
        }
        [TestMethod]
        public void dukePath_TestCase1_ReturnsString()
        {
            DukeOnChessBoard dukeOnChessBoard = new DukeOnChessBoard();
            String results = dukeOnChessBoard.dukePath(4, "d4");
            String ans = "d4-d3-d2-d1-c1-c2-c3...b3-b2-b1-a1-a2-a3-a4";
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void dukePath_TestCase2_ReturnsString()
        {
            DukeOnChessBoard dukeOnChessBoard = new DukeOnChessBoard();
            String results = dukeOnChessBoard.dukePath(3, "a2");
            String ans = "a2-b2-c2-c3-b3-a3";
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void dukePath_TestCase3_ReturnsString()
        {
            DukeOnChessBoard dukeOnChessBoard = new DukeOnChessBoard();
            String results = dukeOnChessBoard.dukePath(4, "d3");
            String ans = "d3-d4-c4-c3-c2-d2-d1...b2-b3-b4-a4-a3-a2-a1";
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void dukePath_TestCase4_ReturnsString()
        {
            DukeOnChessBoard dukeOnChessBoard = new DukeOnChessBoard();
            String results = dukeOnChessBoard.dukePath(8, "a8");
            String ans = "a8-b8-c8-d8-e8-f8-g8...a1-a2-a3-a4-a5-a6-a7";
            Assert.AreEqual(ans, results);
        }

    }
}
