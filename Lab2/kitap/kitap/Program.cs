using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace kitap
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> sozluk =
              new Dictionary<string, string>(){
                                {"Yüzük Kardeşliği", "9789753425"},
                                {"İki Kule", "9753421818"},
                                {"Kralın Dönüşü", "9753422024"},
                                {"Dune", "605375479X"},
                                {"Dune Çocukları", "6053756024"},
                                {"Anayurt", "6053755575"},
                                {"Sürgün", "6059958133"},
                                {"Dünyanın Gözü", "9758725718"},
                                {"Büyük Av", "9758725726"}};
            

            Console.WriteLine("Lütfen ISBN numarasını öğrenmek istediğiniz kitabın adını giriniz: ");
            string kitapAdi = Console.ReadLine();

            Stopwatch stopwatch = new Stopwatch();


            stopwatch.Start(); // if-else süre başlangıcı
            if (sozluk.ContainsKey(kitapAdi) == true)
            {
                Console.WriteLine("Kitabın ISBN numarası: " + sozluk[kitapAdi]);
            }

            else
                Console.WriteLine("Böyle bir kitap bulunamadı.");
            stopwatch.Stop(); //if-else süre bitişi
            Console.WriteLine("if-else ifadesi ile yapılan işlem süresi: " + stopwatch.Elapsed);
            

            stopwatch.Start(); // switch-case süre başlangıcı
            switch(kitapAdi)
            {
                case "Yüzük Kardeşliği":
                    Console.WriteLine("Kitabın ISBN numarası: " + sozluk[kitapAdi]);
                    break;
                case "İki Kule":
                    Console.WriteLine("Kitabın ISBN numarası: " + sozluk[kitapAdi]);
                    break;
                case "Kralın Dönüşü":
                    Console.WriteLine("Kitabın ISBN numarası: " + sozluk[kitapAdi]);
                    break;
                case "Dune":
                    Console.WriteLine("Kitabın ISBN numarası: " + sozluk[kitapAdi]);
                    break;
                case "Dune Çocukları":
                    Console.WriteLine("Kitabın ISBN numarası: " + sozluk[kitapAdi]);
                    break;
                case "Anayurt":
                    Console.WriteLine("Kitabın ISBN numarası: " + sozluk[kitapAdi]);
                    break;
                case "Sürgün":
                    Console.WriteLine("Kitabın ISBN numarası: " + sozluk[kitapAdi]);
                    break;
                case "Dünyanın Gözü":
                    Console.WriteLine("Kitabın ISBN numarası: " + sozluk[kitapAdi]);
                    break;
                case "Büyük Av":
                    Console.WriteLine("Kitabın ISBN numarası: " + sozluk[kitapAdi]);
                    break;
               
                default:
                    Console.WriteLine("Böyle bir kitap bulunamadı.");
                    break;

             
            }

            stopwatch.Stop();
            Console.WriteLine("Swithc-case ile geçen süre: " + stopwatch.Elapsed);
        }
    }
}
