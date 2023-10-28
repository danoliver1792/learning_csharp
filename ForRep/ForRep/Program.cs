// estrutura do for

/* for (inicio; condicao; incremento {
 *  inicio -> executa somente na primeira vez
 *  condicao -> se verdadeiro: executa e volta, se falso: pula fora
 *  incremento -> executad toda vez depois de voltar
 * }
 */

using System;

namespace ForRep
{
    class Program
    {
        static void Main(string[] args)
        {
            // digitar um numero N e depois N valores inteiros. Mostrar a soma dos N valores digitados
            Console.Write("Quantos numeros inteiros voce ira digitar: ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("Soma = " + soma);
        }
    }
}
