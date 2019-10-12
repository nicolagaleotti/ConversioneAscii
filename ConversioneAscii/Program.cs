using System;
using System.Text;

namespace ConversioneAscii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci qualcosa: ");
            string risposta = Console.ReadLine();
            byte[] bytes = Encoding.ASCII.GetBytes(risposta);
            foreach (var c in bytes)
                {
             
               // int result = BitConverter.ToInt32(bytes, 0);
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}
