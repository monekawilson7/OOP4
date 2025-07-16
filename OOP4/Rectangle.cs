using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double Area { 
        get { return Width * Length; }
        }
        public void DisplayShapeInfo() {
            Console.WriteLine($"Shape: Rectangle");
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Area: {Area:F2}");
        }
    }
}
