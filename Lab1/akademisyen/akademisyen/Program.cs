using System;

namespace akademisyen
{
    public class Program
    {
        public class Akademisyenler
        {

            public String KullanıciAdi;
            public String Sifre;
            public String Mail;
            public String Adi;
            public String Soyadi;
            public String Akademikünvan;

            public Akademisyenler(String Kullaniciadi1, String Sifre1, String Mail1, String Adi1, String Soyadi1, String Akademikünvan1)
            {
                KullanıciAdi = Kullaniciadi1;
                Sifre = Sifre1;
                Mail = Mail1;
                Adi = Adi1;
                Soyadi = Soyadi1;
                Akademikünvan = Akademikünvan1;

            }
            public String Bilgi()
            {
                // string a = KullanıciAdi + Sifre + Mail + Adi + Soyadi + Akademikünvan;
                return KullanıciAdi + Sifre + Mail + Adi + Soyadi + Akademikünvan;


            }
            public void yazdir()
            {
                Console.WriteLine(KullanıciAdi);
                Console.WriteLine(Sifre);
                Console.WriteLine(Mail);
                Console.WriteLine(Adi);
                Console.WriteLine(Soyadi);
                Console.WriteLine(Akademikünvan);
            }

        }
        public string bilgi(string a)

        {
            return "";

        }

        static void Main(string[] args)
        {
            Akademisyenler RDAS = new Akademisyenler("rdas", "785123", "Resul ", "Das", "Prf.Dr", "Resuldas@gmail.com");
            Akademisyenler MBAYKARA = new Akademisyenler("Mbaykara", "457876", "Muhammed", "Baykara", "Dr.Öğr üyesi", "muhammedbaykara23@gmail.com");
            Akademisyenler Tbalakus = new Akademisyenler("Tbalakus", "123456", "Talha Burak", "Alakus", "Arş Gör", "Burak.Alakus@gmail.com");
            Akademisyenler bpolat = new Akademisyenler("bpolat", "456128", "Berna", "Polat", "Arş Gör", "brnapolattt@gmail.com");
            String Rdasbilgi = RDAS.Bilgi();
            RDAS.yazdir();




            Console.Read();

        }
    }
}
