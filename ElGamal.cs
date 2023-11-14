using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ElectronicDigitalSignature
{
    internal class ElGamal
    {
        public ElGamal() 
        { 

        }

        static private int Simple()
        {
            int n = 0;

            Random rnd = new Random();

            bool good = false;

            while (!good)
            {
                
                n = rnd.Next(3, 50);

                int count = 0;

                for (int i = 2; i < n / 2; i++)
                {
                    if (n % i == 0)
                        count++;
                }

                if (count == 0)
                    good = true;
            }

            return n;
        }

        public static bool IsCoprime(int a, int b)
        {
            return a == b
                   ? a == 1
                   : a > b
                        ? IsCoprime(a - b, b)
                        : IsCoprime(b - a, a);
        }

        static public string Decoding(string massenge)
        {
            Random rnd = new Random();
            //Условие Эль-Гамаля
            int p = Simple(), g = rnd.Next(0, p), x = rnd.Next(0, p), y = (int)Math.Pow(g, x) % p, 
                k = 0, a = 0, b = 0;

            //Формирования подписи
            bool good = false;

            //Взаимно простое число с p - 1
            while (!good)
            {
                k = rnd.Next(1, p);

                if (IsCoprime(k, p - 1))
                    good = true;
            }

            a = (int) Math.Pow(g, k) % p;
            b = (int)((massenge.Length - x * a) / k) % (p - 1);

            return $"{a}{b}";
        }
    }
}
