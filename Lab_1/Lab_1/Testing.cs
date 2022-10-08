
using System;

namespace Lab_1
{
    internal class Testing
    {

        public static void UnavailableNameTest()
        {
            try
            {
                var GameAccount = new GameAccount("User");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Can`t create first account");
            }

            try
            {
                var GameAccount = new GameAccount("User");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Can`t create second account");
            }

        }

    }
}
