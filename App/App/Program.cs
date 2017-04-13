using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Suma suma = new Suma();
            Console.WriteLine(suma.Operacion(1,2));
            Console.ReadLine();
        }
    }

    class Suma
    {
        public int Operacion(int a, int b)
        {
            return a + b;
        }
    }
}
