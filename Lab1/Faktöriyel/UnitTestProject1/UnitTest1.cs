using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp9;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void TestTopla()
        {

            Program t = new Program();
            double sonuç = t.topla(20, 10, 10, 10);
            Assert.AreEqual(sonuç, 40);

        }
        [TestMethod]

        public void TestCikar()
        {

            Program t = new Program();
            double sonuç = t.cikar(30, 10, 15, 10);
            Assert.AreEqual(sonuç, 5);

        }
        [TestMethod]

        public void TestBolme()
        {

            Program t = new Program();
            double sonuç = t.bolme(120, 10, 1, 2);
            Assert.AreEqual(sonuç, 6);

        }
        [TestMethod]

        public void TestCarpma()
        {

            Program t = new Program();
            double sonuç = t.carpma(5, 5, 4, 2);
            Assert.AreEqual(sonuç, 200);

        }
        [TestMethod]

        public void Faktoriyel()
        {

            Program t = new Program();
            double sonuç = t.faktoriyel(7);
            Assert.AreEqual(sonuç, 120);

        }

        public void TestMethod1()
        {
        }
    }
}
