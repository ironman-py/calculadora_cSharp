using System;

namespace Calculadora

{
    class Program

    {
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu()
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Divisão");
            Console.WriteLine("3 - Subtração");
            Console.WriteLine("4 - multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-------------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());


            switch(res)
            {
                case 1: Soma();break;
                case 2: Divisao();break;
                case 3: Subtracao();break;
                case 4: Multiplicacao();break;
                case 5: System.Environment.Exit(0);break;
                default: Menu();break;
            }
        }

        
        
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite um número: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite um segundo número: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da operação é {v1 + v2}");

            Menu();
        }

        static void Divisao()
        {
           Console.Clear();
            Console.WriteLine("Digite um número: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite um segundo número: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da operação é {v1 / v2}"); 

            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite um número: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite um segundo número: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da operação é {v1 - v2}");

            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite um número: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite um segundo número: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da operação é {v1 * v2}");

            Menu();
        }

        
    }   


        

}