/*
e: &&
ou: ||
nao: !
*/

using System;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 && 4 != 5; // false
            bool c2 = 2 > 3 || 4 != 5; // true
            // precendencia: ! > && > ||
            bool c3 = !(2 > 3) && 4 != 5; // true

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine("-------------");

            bool c4 = 10 < 5;
            bool c5 = c1 || c2 && c4; // false
            Console.WriteLine(c5);
        }
    }
}
