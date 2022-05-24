using System;
using System.Diagnostics;
using System.Linq;

namespace harfSirasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            string[] harfler = {"a", "b", "c", "ç", "d", "e",
                                "f", "g", "ğ", "h", "ı", "i",
                                "j", "k", "l", "m", "n", "o",
                                "ö", "p", "r", "s", "ş", "t",
                                "u", "ü", "v", "y", "z"};
            Console.Write("Bir harf giriniz: ");
            string harf = Console.ReadLine();

            

            stopwatch.Start(); //if-else süre başlangıcı
            if (harfler.Contains(harf))
            {
                int sira = Array.IndexOf(harfler, harf) + 1;
                Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sira);
            }
            else
            {
                Console.WriteLine("Böyle bir harf bulunamadı.");
            }
            stopwatch.Stop(); //if-else süre bitiş
            Console.WriteLine("if-else ile geçen süre: " + stopwatch.Elapsed);

            int sirasw = Array.IndexOf(harfler, harf) + 1;

            stopwatch.Start(); // Switch-case süre başlangıcı
            switch(harf)
            {
                case "a":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "b":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "c":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "ç":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "d":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "e":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "f":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "g":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "ğ":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "h":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "ı":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "i":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "j":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "k":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "l":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "m":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "n":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "o":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "ö":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "p":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "r":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "s":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "t":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "u":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "ü":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "v":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "y":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                case "z":
                    Console.WriteLine("Girdiğiniz harf {0}. sıradadır", sirasw);
                    break;
                default:
                    Console.WriteLine("Böyle bir harf bulunamadı.");
                    break;

            }
            stopwatch.Stop();
            Console.WriteLine("Switch-case ile geçen süre: " + stopwatch.Elapsed);
            

        }
    }
}
