namespace Exercise1_SolutionUnitTest
{
    [TestClass]
    public class MailboxUnitTest
    {
        [TestMethod]
        public void impossible_TestCase0_ReturnsInt()
        {
            Mailbox mailbox = new Mailbox();
            int results = mailbox.impossible("AAAAAAABBCCCCCDDDEEE123456789", new String[] { "123C", "123A", "123 ADA" });
            int ans = 0;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void impossible_TestCase1_ReturnsInt()
        {
            Mailbox mailbox = new Mailbox();
            int results = mailbox.impossible("ABCDEFGHIJKLMNOPRSTUVWXYZ1234567890", new String[] { "2 FIRST ST", " 31 QUINCE ST", "606 BAKER" });
            int ans = 3;
            Assert.AreEqual(ans, results);
        }

        [TestMethod]
        public void impossible_TestCase2_ReturnsInt()
        {
            Mailbox mailbox = new Mailbox();
            int results = mailbox.impossible("ABCDAAST", new String[] { "111 A ST", "A BAD ST", "B BAD ST" });
            int ans = 2;
            Assert.AreEqual(ans, results);
        }
    }
}
