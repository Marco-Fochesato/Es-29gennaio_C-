using System;

namespace consoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Inserisci un numero");

            bool x = int.TryParse(Console.ReadLine(), out n);
            while (!x || n < 1)
            {
                Console.WriteLine("ERRORE, inserisci un numero valido");
                x = int.TryParse(Console.ReadLine(), out n);
            }

            Console.WriteLine("Numeri primi compresi tra 1 e " + n + ":");

            for (int i = 2; i <= n; i++)
            {
                bool primo = true;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
