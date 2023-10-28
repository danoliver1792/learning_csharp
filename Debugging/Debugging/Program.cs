// atalhos para debugging

// F9 -> marcar/desmarcar breakpoint
// F5 -> iniciar/continuar o debug
// F10 -> executar um passo (pula funcao)
// shift + F11 -> sair do metodo em execucao
// shift + F5 -> parar debug

using System;

namespace Debug
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
