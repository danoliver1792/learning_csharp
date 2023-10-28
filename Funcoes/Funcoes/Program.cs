// funcoes podem receber dados de entrada (parametros ou argumentos)
// funcoes podem ou nao retornar uma saida
// em orientacao a objetos, funcoes em classes recebem o nome de metodos

// funcao para ler tres numeros inteiros e indicar o maior dos tres
using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite tres numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior: " + resultado);
        }

        static int Maior(int a, int b, int c)
        {
            int m;

            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}
