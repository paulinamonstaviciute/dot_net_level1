using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antras_projektas
{
    //sukurdami klase sukuriam nauja tipa
    class Rectangle
    {
        //member variables - blogas komentaras
        private double lenght;
        private double width;

        public void AcceptDetails()
        {
            lenght = 4.5;
            width = 3.5;
        }
        public double GetArea() 
        {
            return lenght * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", lenght);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //sukuriam nauja kintamaji
            Rectangle r = new Rectangle();
            r.AcceptDetails();
            r.Display();
            Console.ReadLine();
        }
    }
}