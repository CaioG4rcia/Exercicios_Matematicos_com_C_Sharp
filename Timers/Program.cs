
namespace Crônometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("Escolhe uma das opções");
            Console.WriteLine("=========================");
            Console.WriteLine("1 - Timer de 30 segundos");
            Console.WriteLine("2 - Timer de 5 minutos");
            Console.WriteLine("3 - Timer de 30 minutos");
            Console.WriteLine("4 - Timer Personalizado");
            Console.WriteLine("=========================");

            int res = int.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Timer30Seg(); break;
                case 2: Timer5Min(); break;
                case 3: Timer30Min(); break;
                case 4: TimerPersonalizado(); break;
            }
        }
        static void End()
        {
            Console.WriteLine("=====================");
            Console.WriteLine("Timer Finalizado!");
            Console.WriteLine("=====================");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        static void Timer30Seg()
        {
            for (int i = 30; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            End();
            Console.Clear();
            Menu();

        }
        static void Timer5Min()
        {
            for (int i = 300; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            End();
            Console.Clear();
            Menu();
        }
        static void Timer30Min()
        {
            for (int i = 1800; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            End();
            Console.Clear();
            Menu();
        }
        static void TimerPersonalizado()
        {
            Console.WriteLine("Digite o Tempo para inciar Cronômetro: ");

            var temp = int.Parse(Console.ReadLine());

            for (int i = temp; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            End();
            Console.Clear();
            Menu();
        }
    }
}