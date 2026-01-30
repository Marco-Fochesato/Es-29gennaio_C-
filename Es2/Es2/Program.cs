using System;

namespace Es2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleziona il livello di difficoltà:");
            Console.WriteLine("1. Facile (numeri da 1 a 5)");
            Console.WriteLine("2. Medio (numeri da 1 a 10)");
            Console.WriteLine("3. Difficile (numeri da 1 a 20)");
            string scelta = Console.ReadLine() ?? "";

            int maxrnd = 5;
            if(scelta == "1")
            {
                maxrnd = 5;
            }
            else if(scelta == "2")
            {
                maxrnd = 10;
            }
            else if(scelta == "3")
            {
                maxrnd = 20;
            }
            else
            {
                Console.WriteLine("ERRORE scelta non valida");
            }

            Random rnd = new(); 
            int numeroRandom = rnd.Next(1, maxrnd + 1);
            int tentativi = 3;

            while (tentativi > 0)
            {
                Console.WriteLine($"Indovina il numero (tra 1 e {maxrnd}). Hai {tentativi} tentativi rimasti:");
                string input = Console.ReadLine() ?? "";
                int numeroUtente;

                if (!int.TryParse(input, out numeroUtente))
                {
                    Console.WriteLine("Per favore, inserisci un numero valido.");
                    continue;
                }

                if (numeroUtente == numeroRandom)
                {
                    Console.WriteLine("Complimenti! Hai indovinato il numero!");
                    break;
                }
                else
                {
                    tentativi--;
                    if (numeroUtente < numeroRandom)
                    {
                        Console.WriteLine("Il numero è troppo basso!");
                    }
                    else
                    {
                        Console.WriteLine("Il numero è troppo alto!");
                    }
                    
                    if (tentativi == 0)
                    {
                        Console.WriteLine($"Mi dispiace, hai esaurito i tentativi. Il numero era {numeroRandom}.");
                    }
                    else
                    {
                        Console.WriteLine("Riprova.");
                    }
                }
            }
        }
    }
}