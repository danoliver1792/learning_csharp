// conversao implicita entre tipos e quando um conteudo de certo tipo pode ser naturalmente atribuito para uma variavel de outro tipo
// casting e a conversao explicita entre tipos compativeis

using System;

namespace ImpCas
{
    class Program
    {
        static void Main(string[] args)
        {
            // conversao implicita, o valor de float cabe dentro de double
            float x = 4.5f;
            double y = x;

            Console.WriteLine(y);

            // o processo inverso nao dara certo, entao faremos um casting
            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);

            int c = 5;
            int d = 2;

            double resultado = (double) c / d;
            Console.WriteLine(resultado);
        }
    }
}
