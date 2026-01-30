using System;
namespace Es3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int o1=0;
            int o2=0;
            Console.WriteLine("inserisci il numero dei pezzi dell'primo ordine:");
            bool x= int.TryParse(Console.ReadLine(), out o1); 
            Console.WriteLine("inserisci il numero dei pezzi del secondo ordine:");
            bool y= int.TryParse(Console.ReadLine(), out o2);

            static int CalcolaMCD(int o1, int o2)
            {
                while (o2 != 0)
                {
                    (o1, o2) = (o2, o1 % o2);
                }
                return Math.Abs(o1);
            }
            Console.WriteLine("il massimo comune divisore tra i due ordini è: " + CalcolaMCD(o1, o2));


        }
    }
}