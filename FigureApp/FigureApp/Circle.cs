/* The circle class include a data members for
* radius. It has an instance method
* to calculate the area and a ToString( ) 
* method that returns a string containing
* the dimensions and area.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureApp
{
    class Circle
    {
        private double radius;

        public Circle()
        {
        }

        public Circle(double rad)
        {
            radius = rad;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        //Property definitions
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public override string ToString()
        {
            return "Circle" +
                   "\nRadius: " + radius +
                   "\nArea: " + CalculateArea().ToString("N2");
        }

    }
}
