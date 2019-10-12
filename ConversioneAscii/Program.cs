using System;

namespace ConversioneAscii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci qualcosa: ");
            string risposta = Console.ReadLine();
            foreach (char c in risposta)
            {
                Console.WriteLine(System.Convert.ToInt32(c));
            }
            Console.ReadLine();
        }
    }
}
