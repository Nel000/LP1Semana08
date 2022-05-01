using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit mU = new MilitaryUnit(10, 20, 15);
            Unit sU = new SettlerUnit(20, 10);

            string mMov = mU.Move();
            string sMov = sU.Move();

            Console.WriteLine($"{mU.GetType()} \n{mU.ToString()}");
            Console.WriteLine("");
            Console.WriteLine($"{sU.GetType()} \n{sU.ToString()}");
            Console.WriteLine("");
            Console.WriteLine(mMov);
            Console.WriteLine(sMov);

            Console.WriteLine("Testing git tag manipulation");
        }
    }
}
