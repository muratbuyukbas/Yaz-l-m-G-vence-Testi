using Microsoft.VisualStudio.TestTools.UnitTesting;
using labStringReverse;

namespace labfirstUnittest
{
    [TestClass]
    
    public class UnitTest1
    {
        public void testBilgi()
        {
            Program p = new Program();
            string metin = "murat";
            string beklenen = "tarum";
            string gerceklesen = p.TersCevir(metin);
            Assert.AreEqual(beklenen, gerceklesen);
        }
    }
}
