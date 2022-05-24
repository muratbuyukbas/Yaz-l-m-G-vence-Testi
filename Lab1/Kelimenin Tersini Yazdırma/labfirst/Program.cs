using System;
namespace labStringReverse
{

    public class Program
    {
    

        public string TersCevir(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        public static void Main()
        {
           
        }
    }
}