using System;
using System.Collections;

namespace ConsoleApp1
{
    class Estruturas
    {
        static void Main(string[] args)
        {
            Stack objeto = new Stack();
            objeto.Push(5);
            objeto.Push(7);
            objeto.Push(9);
            objeto.Push(4);
            objeto.Push(5);
            Console.WriteLine("Números adicionados na pilha.");
            foreach (Object obj in objeto)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Números que permaneceram na pilha.");
            objeto.Pop();
            foreach(Object obj in objeto)
            {
                Console.WriteLine(obj);
            }
            ArrayList objeto1 = new ArrayList();
            objeto1.Add(5);
            objeto1.Add(7);
            objeto1.Add(9);
            objeto1.Add(4);
            objeto1.Add(5);
            Console.WriteLine("Números adicionados na lista.");
            for (int i =0; i <= 4; i++)
            {
                Console.WriteLine(objeto1[i]);
            }
            Console.WriteLine("Números que permaneceram da lista.");
            objeto1.RemoveAt(2);
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(objeto1[i]);
            }
            Queue objeto2 = new Queue();

            objeto2.Enqueue(5);
            objeto2.Enqueue(7);
            objeto2.Enqueue(9);
            objeto2.Enqueue(4);
            objeto2.Enqueue(5);
            Console.WriteLine("Números adicionados na fila.");
            foreach (Object obj in objeto2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Números que permaneceram da fila.");
            objeto2.Dequeue();
            foreach (Object obj in objeto2)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
