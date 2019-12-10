using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmas_savarankiskas_darbas
{
    class Program
    {
        static void Main(string[] args)
        {
            string spalva = "";
            while (spalva != "stop")
            {
                Console.WriteLine("Iveskite savo megstamiausia spalva:");
                spalva = Console.ReadLine();
                Console.WriteLine("Mano irgi!");
                Console.WriteLine("Jei norite nutraukti rasykite stop");
            }
        }
    }
}