using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro
{
    class Intervalo2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Informe o número. ");
            int numero = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" Informe o número. ");
            int numero1 = Int32.Parse(Console.ReadLine());
            int i = numero, cont = numero1;
            Console.Clear();
            Console.WriteLine(" Números entre " + numero + " e " + numero1);
            for (i = numero; i < cont; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
