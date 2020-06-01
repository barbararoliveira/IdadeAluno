using System;

namespace IdadeAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pressione enter para saber mais informações sobre mim (Bárbara):");
            Console.ReadKey();

            DateTime barbara = new DateTime (2004, 04, 06, 16, 13, 00);
            string barbaradtl = barbara.ToLongDateString(); //dtl = data longa 

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Eu nasci em {barbaradtl}");

            DateTime bday = barbara.AddYears(18);
            string bday18 = bday.ToLongDateString();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Meu aniversário de 18 anos é {bday18}");
        }
    }
}
