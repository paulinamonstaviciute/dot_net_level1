using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antras_savarankiskas_darbas
{
    class Calculator
    {
        private int pirmas;
        private int antras;
        public void PriimtiSkaicius()
        {
            pirmas = 17;
            antras = 23;
        }
        public int sudedame()
        {
            return pirmas + antras;
        }
        public void Display()
        {
            Console.WriteLine("Pirmas skaicius: {0}", pirmas);
            Console.WriteLine("Antras skaicius: {0}", antras);
            Console.WriteLine("suma: {0}", sudedame());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator naujas_kintamasis = new Calculator();
            naujas_kintamasis.PriimtiSkaicius();
            naujas_kintamasis.Display();
            Console.ReadLine();
        }
    }
}
