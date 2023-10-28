// + -> adicao
// - -> subtracao
// * -> multiplicacao
// / -> divisao
// % -> resto da divisao

using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 2;
            double n4 = (double)10 / 8;
            // tambem funciona:
            double n5 = 10.0 / 8;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
        }
    }
}
