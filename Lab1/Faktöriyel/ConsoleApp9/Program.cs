using System;

namespace ConsoleApp9
{
    public class Program
    {
        public double topla(double m1, double m2, double m3, double m4)
        {

            return m1 + m2 + m3 + m4;
        }
        public double cikar(double m1, double m2, double m3, double m4)
        {

            return ((m1 - m2) - m3) - (m4);
        }
        public double bolme(double m1, double m2, double m3, double m4)
        {

            return ((m1 / m2) / m3) / (m4);
        }
        public double carpma(double m1, double m2, double m3, double m4)
        {

            return ((m1 * m2) * m3) * (m4);
        }
        public double faktoriyel(double m1)
        {
            if (m1 == 1)
            {
                return 1;
            }

            return faktoriyel(m1 - 1) * m1;
        }

        static void Main(string[] args)
        {

        }
    }
}
