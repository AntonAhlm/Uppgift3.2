using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? Svara \"J\" eller \"N\" ");
            string svar = Console.ReadLine();
            string svarLC = svar.ToLower();

            Console.WriteLine("Hur gammal är du?");
            int ålder = Convert.ToInt32(Console.ReadLine());

            if (ålder < 22 && svarLC == "j")
                Console.WriteLine("Vi vill gärna anställa dig.");
            else
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu"); 


        }
    }
}
