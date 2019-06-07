using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, informe um número. ");
            int numero = Int32.Parse(Console.ReadLine());
            Console.WriteLine(intervalo(numero));
        }

        public static bool intervalo(int numero)
        {
            if (numero > 10 && numero < 100)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}