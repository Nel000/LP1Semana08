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

            Console.WriteLine(
                $"{mU.GetType()}: Health - {mU.Health}, Value - {mU.Value}");
            Console.WriteLine(
                $"{sU.GetType()}: Health - {sU.Health}, Value - {sU.Value}");
            Console.WriteLine(mMov);
            Console.WriteLine(sMov);
        }
    }
}
