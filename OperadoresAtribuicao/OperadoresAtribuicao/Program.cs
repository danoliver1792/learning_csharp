// operadores de atribuicao

// = -> a = 10; -> a recebe 10
// += -> a += 2; -> a + 2
// -= -> a -= 2; -> a - 2
// *= -> a *= 2; -> a * 2
// /= -> a /= 2; -> a / 2
// %= -> a % 2; -> a % 2


// incrementacao

// ++ -> a++; ou ++a; -> a = a + 1
// -- -> a--; ou --a; -> a = a - 1

using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a -= 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            a /= 10;
            Console.WriteLine(a);

            // o += funciona com string
            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            // testando incrementacao
            int b = 10;
            b++;
            Console.WriteLine(b);

            int c = 20;
            c--;
            Console.WriteLine(c);

            --c;
            Console.WriteLine(c);

        }
    }
}
