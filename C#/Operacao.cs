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
            float numero = Console.Read();
            Console.WriteLine("Por favor, informe um número. ");
            float numero1 = Console.Read();
            Console.WriteLine("Soma: " + soma(numero, numero1));
            Console.WriteLine("Divisão: " + divisao(numero, numero1));
            Console.WriteLine("Multiplicação: " + multiplicacao(numero, numero1));
            Console.WriteLine("Subtração: " + subtracao(numero, numero1));
            Console.Write("Resto: " + numero % numero1);
        }

        public static float soma(float numero, float numero1)
        {
            return numero + numero1;
        }

        public static float divisao(float numero, float numero1){
            return numero / numero1;
        }

        public static float multiplicacao(float numero, float numero1)
        {
            return numero * numero1;
        }

        public static float subtracao(float numero, float numero1){
            return numero - numero1;
        }
    }
}