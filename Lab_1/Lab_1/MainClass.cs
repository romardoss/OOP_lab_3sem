using System;

namespace Lab_1
{
    internal class MainClass
    {
        static void Main(string[] args)
        {

            //Testing.UnavailableNameTest();
            //Testing.ArgumentOutOfRangeTest1();
            //Testing.ArgumentOutOfRangeTest2();
            //Testing.ArgumentOutOfRangeTest3();
            //Testing.ArgumentOutOfRangeTest4();
            GameAccount Roma = new GameAccount("Roma");
            var Dima = new GameAccount("Dima");
            var Vasya = new GameAccount("Vasya");

            Roma.WinGame(Dima, 30);
            Vasya.LoseGame(Roma, 100);
            Dima.WinGame(Roma, 200);


            Console.WriteLine(Dima.GetStats());
            Console.WriteLine(Roma.GetStats());
        }
    }
}
