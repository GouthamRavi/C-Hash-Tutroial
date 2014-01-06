using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIntegration
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    abstract class Veichle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
    }

    class Car : Veichle
    {
         
    }
}
