using System;
using System.Collections.Generic;

namespace TDI2
{
    class Estruturas
    {
        static void Main()
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(8);
            Console.WriteLine(numbers.Count);
        }
    }
}