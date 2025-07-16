using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    public class Circle
    {
        public double Radius { get; set; }
        public double Area {
            get { 
            return Math.PI * Radius * Radius; 
            }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Circle");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {Area:F2}");
        }
    }
}
