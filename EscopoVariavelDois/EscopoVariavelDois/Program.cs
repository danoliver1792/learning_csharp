﻿using System;

namespace Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;

            if (preco > 100.00)
            {
                // declaracao double foi declarada na estrutura principal, nao precisa declarar de novo
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
        }
    }
}
