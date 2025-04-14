using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] strg)
        {

            Menu();

        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Escolha a operação Matematica");
            Console.WriteLine("==============================");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("==============================");

            int res = int.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                default: Menu(); break;

            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Operação Escolhida: Soma");
            Console.WriteLine("==============================");

            float[] bases = new float[2];

            Console.WriteLine("Digite o Primeiro Número: ");
            var n1 = bases[0] = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Número: ");
            var n2 = bases[1] = float.Parse(Console.ReadLine());
            var soma = n1 + n2;
            Console.WriteLine($"{n1} + {n2} = {soma}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Operação Escolhida: Subtração");
            Console.WriteLine("==============================");

            float[] bases = new float[2];

            Console.WriteLine("Digite o Primeiro Número: ");
            var n1 = bases[0] = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Número: ");
            var n2 = bases[1] = float.Parse(Console.ReadLine());
            var subtracao = n1 - n2;
            Console.WriteLine($"{n1} - {n2} = {subtracao}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Operação Escolhida: Multiplicação");
            Console.WriteLine("==============================");

            float[] bases = new float[2];

            Console.WriteLine("Digite o Primeiro Número: ");
            var n1 = bases[0] = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Número: ");
            var n2 = bases[1] = float.Parse(Console.ReadLine());
            var multiplicacao = n1 * n2;
            Console.WriteLine($"{n1} x {n2} = {multiplicacao}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Operação Escolhida: Divisão");
            Console.WriteLine("==============================");

            float[] bases = new float[2];

            Console.WriteLine("Digite o Primeiro Número: ");
            var n1 = bases[0] = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Número: ");
            var n2 = bases[1] = float.Parse(Console.ReadLine());
            var divisao = n1 / n2;
            Console.WriteLine($"{n1} % {n2} = {divisao}");
            Console.ReadKey();
            Menu();
        }
    }
}