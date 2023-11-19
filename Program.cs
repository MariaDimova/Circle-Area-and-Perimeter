using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area_and_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // чете от конзолата число r и пресмята и отпечатва лицето S и периметъра P на кръг
           //  окръжност с радиус r.
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimeter = Math.PI * 2 * r;

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
