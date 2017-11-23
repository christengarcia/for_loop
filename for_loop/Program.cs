using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }*/

            int[] myNumbers = { 3, 8, 2, 37, 21, 55, 34, 88 };

            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }
        }
    }
}
