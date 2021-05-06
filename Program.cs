using System;

namespace ExercicioNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            digite("Digite um número natural: ");
            valor(Console.ReadLine());
        }

        static void digite(string digite)
        {
            Console.Write(digite);
        }

        static void valor(string valor)
        {
            int a;
            a = Convert.ToInt32(valor);

            if (a < 0)
            {
                Console.WriteLine("Você digitou um número negativo.");
            }

            else 
            {
                Console.WriteLine($"Você digitou {a}.");
            }
        }
    }
}
