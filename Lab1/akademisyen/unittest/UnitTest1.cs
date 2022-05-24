using Microsoft.VisualStudio.TestTools.UnitTesting;
using akademisyen;
using static akademisyen.Program;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void nesne1()
        {
            Program a = new Program();
            Akademisyenler d = new Akademisyenler("rdas", "785123", "Resuldas@gmail.com", "Resul", "Das", "Prf.Dr");

            string KullaniciAdi = "rdas";
            string Sifre = "785123";
            string Mail = "Resuldas@gmail.com";
            string Adi = "Resul";
            string Soyadi = "Das";
            string Akademikunvan = "Prf.Dr";
            string beklenen = KullaniciAdi + Sifre + Mail + Adi + Soyadi + Akademikunvan;
            string gerceklesen = d.Bilgi();
            Assert.AreEqual(beklenen, gerceklesen);
        }

        public void nesne2()
        {
            Program a = new Program();
            Akademisyenler d = new Akademisyenler("Mbaykara", "457876", "Muhammed", "Baykara", "Dr.Öğr Üyesi", "muhammedbaykara23@gmail.com");

            string KullaniciAdi = "Mbaykara";
            string Sifre = "457876";
            string Mail = "muhammedbaykara23@gmail.com";
            string Adi = "Muhammed";
            string Soyadi = "Baykara";
            string Akademikunvan = "Dr.Öğr Üyesi";
            string beklenen = KullaniciAdi + Sifre + Mail + Adi + Soyadi + Akademikunvan;
            string gerceklesen = d.Bilgi();
            Assert.AreEqual(beklenen, gerceklesen);
        }
        public void nesne3()
        {
            Program a = new Program();
            Akademisyenler d = new Akademisyenler("Tbalakus", "123456", "Talha Burak", "Alakus", "Arş Gör", "Burak.Alakus@gmail.com");

            string KullaniciAdi = "Tbalakus";
            string Sifre = "123456";
            string Mail = "Burak.Alakus@gmail.com";
            string Adi = "Talha Burak";
            string Soyadi = "Alakus";
            string Akademikunvan = "Arş Gör";
            string beklenen = KullaniciAdi + Sifre + Mail + Adi + Soyadi + Akademikunvan;
            string gerceklesen = d.Bilgi();
            Assert.AreEqual(beklenen, gerceklesen);
        }
        public void nesne4()
        {
            Program a = new Program();
            Akademisyenler d = new Akademisyenler("bpolat", "456128", "Berna", "Polat", "Arş Gör", "brnapolattt@gmail.com");

            string KullaniciAdi = "bpolat";
            string Sifre = "456128";
            string Mail = "brnapolattt@gmail.com";
            string Adi = "Berna";
            string Soyadi = "Polat";
            string Akademikunvan = "Arş Gör";
            string beklenen = KullaniciAdi + Sifre + Mail + Adi + Soyadi + Akademikunvan;
            string gerceklesen = d.Bilgi();
            Assert.AreEqual(beklenen, gerceklesen);
        }
    }
}
