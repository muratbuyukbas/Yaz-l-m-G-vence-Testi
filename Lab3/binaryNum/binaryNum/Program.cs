using System;

namespace binaryNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, kalan;
            string yazikalan = "";
            Console.Write("İkili tabana çevirmek istediğiniz sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            while (sayi1 != 0)
            {
                kalan = sayi1 % 2;
                sayi1 = sayi1 / 2;

                yazikalan = kalan.ToString() + yazikalan;

            }
            Console.WriteLine("Girdiğiniz sayının ikilik tabanda karşılığı : {0}", yazikalan);

            Console.ReadKey();
        }
    }
}
