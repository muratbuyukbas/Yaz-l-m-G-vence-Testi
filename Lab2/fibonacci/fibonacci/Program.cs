using System;
using System.Diagnostics;


namespace fibonacci
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int x = 0;
            int y = 1;

            Console.Write(x + " " + y + " ");

            stopwatch.Start(); //for döngüsü için süre başladı

            for (int i = 2; i < 10; i++)
            {
                int z = x + y;
                Console.Write(z + " ");
                x = y;
                y = z;
            }

            stopwatch.Stop(); // for döngüsü için süre bitti
            Console.WriteLine(" | Geçen süre: " + stopwatch.Elapsed);

            int a = 0;
            int b = 1;
            int k = 2;

            Console.Write(a + " " + b + " ");

            stopwatch.Start(); // while döngüsü için süre başladı
            while (k < 10)
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
                k++;
            }
            stopwatch.Stop(); //while döngüsü için süre bitti
            Console.WriteLine(" | Geçen süre: " + stopwatch.Elapsed);



            int q = 0;
            int w = 1;
            int e = 2;

            Console.Write(q + " " + w + " ");

            stopwatch.Start(); // do while döngüsü için süre başladı

            do
            {
                int r = q + w;
                Console.Write(r + " ");
                q = w;
                w = r;
                e++;
            } while (e < 10);

            stopwatch.Stop(); // do while döngüsü için süre bitti
            Console.WriteLine(" | Geçen süre: " + stopwatch.Elapsed);
        }
    }
}
