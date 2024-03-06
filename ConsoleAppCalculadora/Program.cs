using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Bem vindo a calculadora escolha a operação que irá fazer.");
            Console.Write("A - Adição, S - Subtração, M - Multiplicação, D - Divisão, Q - Quadrado: ");
            string oper = Console.ReadLine().ToUpper();

            if (oper == "A")
            {
                Console.Write("Digite o primeiro número: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double n2 = double.Parse(Console.ReadLine());

                double result = n1 + n2;

                Console.Write("O resultado da adição é: " + result);
            }
            else if (oper == "S")
            {
                Console.Write("Digite o primeiro número: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double n2 = double.Parse(Console.ReadLine());

                double result = n1 - n2;

                Console.Write("O resultado da subtração é: " + result);
            }
            else if (oper == "M")
            {
                Console.Write("Digite o primeiro número: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double n2 = double.Parse(Console.ReadLine());

                double result = n1 * n2;

                Console.Write("O resultado da multiplicação é: " + result);
            }
            else if (oper == "D")
            {
                Console.Write("Digite o número que será dividido: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o número que dividirá: ");
                double n2 = double.Parse(Console.ReadLine());

                double result = n1 / n2;

                Console.Write("O resultado da divisão é: " + result);
            }
            else if (oper == "Q")
            {
                Console.Write("Digite o número que você deseja elevar ao quadrado: ");
                double n1 = double.Parse(Console.ReadLine());

                double result = n1 * n1;

                Console.Write("O resultado da operação será: " + result);
            }



            Console.ReadKey();
        }
    }
}
