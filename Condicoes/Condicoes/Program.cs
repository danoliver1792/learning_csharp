﻿using System;

namespace Condicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            Console.WriteLine("Bom dia");

            if (x < 5)
            {
                Console.WriteLine("Boa tarde"); // false
            }
            else
            {
                Console.WriteLine("Boa noite"); // true
            }
        }
    }
}
