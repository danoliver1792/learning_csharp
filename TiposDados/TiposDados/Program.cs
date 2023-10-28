using System;

namespace TipoDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // criando uma variavel do tipo sbyte em C# -> -128 to 127
            sbyte x = 100;

            // declarando uma variável do tipo sbyte em .NET, ´só roda com o namespace System -> -128 to 127
            SByte y = 100;

            // declarando uma variavel do tipo byte -> 0 to 255
            byte n1 = 126;
            Console.WriteLine(n1);
            
            // declarando variaveis do tipo inteiro
            int n2 = 1000;
            int n3 = 214783547;
            long n4 = 214783547L;

            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            // declarando variavel do tipo bool
            bool v2 = true;
            bool f2 = false;

            // declarando variavel unicode
            char genero = 'M';
            char letra = '\u0041'; // A

            // declarando variavel do tipo double
            float n5 = 4.5f;
            double n6 = 4.5;

            Console.WriteLine(n5);
            Console.WriteLine(n6);

            // declarando strings
            string nome = "Maria";
            Console.WriteLine(nome);
            // o string e uma cadeia de caracteres unicode que e imutavel (seguranca, simplicidade, thread safe)

            // um object em C# e um objeto generico, toda classe em C# e subclasse de object -> GetType, Equals, GetHashCode, ToString
            object obj1 = "Alex Brown";
            object obj2 = 4.5;

            // overflow -> quando ultrapassa o limite da variavel

            // funcoes para valores minimos e maximos
            // int.MinValue, int.MaxValue...
            
            int n10 = int.MinValue;
            sbyte n11 = sbyte.MaxValue;
            decimal n12 = decimal.MaxValue;

            Console.WriteLine(n10);
            Console.WriteLine(n11);
            Console.WriteLine(n12);

        }
    }
}
