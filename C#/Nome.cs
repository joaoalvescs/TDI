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
            String nome;
            Console.WriteLine("Por favor, informe seu nome. ");
            nome = Console.ReadLine();
            Console.WriteLine(" O seu nome é " + nome);
            Console.ReadKey();
        }
    }
}