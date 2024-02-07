using System;

namespace EXERCICIO5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma string para inverter: \n");
            string input = Console.ReadLine();

            string invertedString = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                invertedString += input[i];
            }

            Console.WriteLine($"String invertida: {invertedString}");
        }
    }
}
