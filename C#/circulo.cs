using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circulo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o raio do círculo. ");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine("O comprimento do círculo é: " + comprimento(raio));
            Console.WriteLine("A área do círculo é: " + area(raio));
        }
        public static double comprimento(double raio)
        {
            return (3.14*raio);
        }

        public static double area(double raio)
        {
            return 3.14 * (raio * 2);
        }
    }
}
