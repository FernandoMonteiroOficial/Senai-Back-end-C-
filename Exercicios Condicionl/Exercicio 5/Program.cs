﻿using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Digite o primeiro numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero");
            num3 = int.Parse(Console.ReadLine());

            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine(num1);
            }
            else if (num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else 
            {
                Console.WriteLine(num3);
            }

        }
    }
}
