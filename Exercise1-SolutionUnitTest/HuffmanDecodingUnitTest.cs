namespace Exercise1_SolutionUnitTest
{
    [TestClass]
    public class HuffmanDecodingUnitTest
    {
        [TestMethod]
        public void Decode_TestCase0_ReturnString()
        {
            //Arrange
            String archive = "101101";
            String[] dictionary = new String[] { "00","10","01","11"};
            String ans = "BDC";
            HuffmanDecoding huffmanDecoding = new HuffmanDecoding();
            
            //Act
            String results = huffmanDecoding.decode(archive, dictionary);

            //Assert
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void Decode_TestCase1_ReturnString()
        {
            //Arrange
            String archive = "10111010";
            String[] dictionary = new String[] { "0", "111", "10" };
            String ans = "CBAC";
            HuffmanDecoding huffmanDecoding = new HuffmanDecoding();

            //Act
            String results = huffmanDecoding.decode(archive, dictionary);

            //Assert
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void Decode_TestCase2_ReturnString()
        {
            //Arrange
            String archive = "0001001100100111001";
            String[] dictionary = new String[] { "1", "0" };
            String ans = "BBBABBAABBABBAAABBA";
            HuffmanDecoding huffmanDecoding = new HuffmanDecoding();

            //Act
            String results = huffmanDecoding.decode(archive, dictionary);

            //Assert
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void Decode_TestCase3_ReturnString()
        {
            //Arrange
            String archive = "111011011000100110";
            String[] dictionary = new String[] { "010", "00", "0110", "0111", "11", "100", "101" };
            String ans = "EGGFAC";
            HuffmanDecoding huffmanDecoding = new HuffmanDecoding();

            //Act
            String results = huffmanDecoding.decode(archive, dictionary);

            //Assert
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void Decode_TestCase4_ReturnsString()
        {
            //Arrange
            String archive = "001101100101100110111101011001011001010";
            String[] dictionary = new String[] { "110", "011", "10", "0011", "00011", "111", "00010", "0010", "010", "0000" };
            String ans = "DBHABBACAIAIC";
            HuffmanDecoding huffmanDecoding = new HuffmanDecoding();

            //Act
            String results = huffmanDecoding.decode(archive, dictionary);

            //Assert
            Assert.AreEqual(ans, results);
        }
    }
}