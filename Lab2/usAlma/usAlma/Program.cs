using System;
using System.Diagnostics;

namespace usAlma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();


            int taban, us, sonuc = 1;
            Console.Write("Taban sayısı: ");
            taban = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kuvveti: ");
            us = Convert.ToInt32(Console.ReadLine());

            stopwatch.Start(); // Recursive süre başlangıcı
            for (int i = 1; i <= us; i++)
            {
                sonuc = sonuc * taban;
            }
            Console.WriteLine("Sonuç: " + sonuc);
            stopwatch.Stop(); // Recursive süre bitişi

            
            Console.WriteLine("Recursive ile geçen süre: " + stopwatch.Elapsed);


            stopwatch.Start(); //Math.Pow süre başlangıcı
            double tabansayi, ussayi, powsonuc;
            Console.Write("Taban sayısı: ");
            tabansayi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kuvveti: ");
            ussayi = Convert.ToDouble(Console.ReadLine());
            powsonuc = Math.Pow(tabansayi, ussayi);
            Console.WriteLine("Sonuç: " + powsonuc);
            stopwatch.Stop(); //Math.Pow süre bitişi

            Console.WriteLine("Math.Pow ile geçen süre: " + stopwatch.Elapsed);



        }
    }
}
