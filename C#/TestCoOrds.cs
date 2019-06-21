using System;

namespace TDI2
{
    class TestCoOrds
    {
        static void Main()
        {
            CoOrds myCoOrds = new CoOrds(10, 15);
            myCoOrds.PrintCoOrds();
        }
    }

    public partial class Employee
    {
        public void DoWork()
        {
        }
    }

    public partial class Employee
    {
        public void GoToLunch()
        {
        }
    }

    public partial class CoOrds
    {
        private int x;
        private int y;

        public CoOrds(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void PrintCoOrds()
        {
            Console.WriteLine("CoOrds: {0}. {1} " + x + " | " + y);
        }
    }
}