using System;

namespace Es4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monete=0;
            int solditot=0;
            while(solditot < 5)
            {
                Console.WriteLine("Quanti soldi vuoi lasciare?");
                bool x= int.TryParse(Console.ReadLine(), out int soldi);
                if (x && soldi > 0)
                {
                    solditot += soldi;
                    Console.WriteLine("Grazie!");
                    monete +=1;
                    
                }
            }
            Console.WriteLine($"Hai inserito {monete} monete per un totale di {solditot} euro.");
        }
    }
}
