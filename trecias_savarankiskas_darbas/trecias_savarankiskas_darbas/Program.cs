using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trecias_savarankiskas_darbas
{
    class Calculator
    {
        private double pirmas;
        private double antras;
        public void PriimtiSkaicius()
        {
            pirmas = 24;
            antras = 5;
        }
        public double Dalyba()
        {
            return pirmas / antras;
        }
        public void Display()
        {
            Console.WriteLine("Pirmas skaicius: {0}", pirmas);
            Console.WriteLine("Antras skaicius: {0}", antras);
            Console.WriteLine("Dalyba: {0}", Dalyba());
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