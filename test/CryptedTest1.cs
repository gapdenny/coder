using Microsoft.VisualStudio.TestTools.UnitTesting;
using Decoder.Model;

namespace test
{
    [TestClass]
    public class CryptedTest1
    {
        private const string Code = "WECRLTEERDSOEEFEAOCAIVDEN";
        private const string UnCode = "WEAREDISCOVEREDFLEEATONCE";

        [TestMethod]
        public void EncryptedTestMethod1() {
            Cipher cipher = new Cipher();
            string result = cipher.getEncryptedData("WEAREDISCOVEREDFLEEATONCE", 3);
            Assert.AreEqual(Code, result);
        }

        [TestMethod]
        public void DecryptedTestMethod1() {
            Cipher cipher = new Cipher();
            string result = cipher.getDecryptedData("WECRLTEERDSOEEFEAOCAIVDEN", 3);
            Assert.AreEqual(UnCode, result);
        }


    }
}
    

