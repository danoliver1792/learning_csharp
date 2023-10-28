using System;
using System.Net.Security;
using System.Globalization;

namespace SaidaDados
{
    class Program
    {
        static void Main(string[] args)
        {   
            // imprime os dados e quebra uma linha
            Console.WriteLine("Hello World");

            // imprime os dados lado a lado
            Console.Write("Hello");
            Console.Write(" ");
            Console.Write("World");

            // teste com variaveis
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);

            // imprimindo com delimitacao de numero de casa -> vamos colocar para duas casas decimais
            Console.WriteLine(saldo.ToString("F2"));

            // imprimindo com ponto separador
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));


            // placeholdes, concatenacao e interpolacao
            // placeholder
            Console.WriteLine("{0} tem {1} anos e R${2} na conta.", nome, idade, saldo.ToString("F2"));

            // interpolacao
            Console.WriteLine($"{nome} tem {idade} anos e R${saldo:F2} na conta.");

            // concatenacao
            Console.WriteLine(nome + " tem " + idade + " anos e R$" + saldo.ToString("F2") + " na conta.");

            // se fosse para mudar "," por "." teria que usar a concatenacao
            Console.WriteLine(nome + " tem " + idade + " anos e R$" + saldo.ToString("F2", CultureInfo.InvariantCulture) + " na conta.");
        }
    }
}
