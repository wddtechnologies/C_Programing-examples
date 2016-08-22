/*Cylinder.cs
 * The cylinder class includes data members for
 * radius and height. It has an instance method
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
    class Cylinder
    {
        private double radius;
        private double height;

        public Cylinder()
        {

        }
        public Cylinder(double rad, double heigh)
        {
            radius = rad;
            height = heigh;
        }

        // Surface area of the side
        public double CalculateSideSurfaceArea()
        {
            return 2 * Math.PI * radius * height;

        }

        // Areas of top and bottom of both circles + Area of the side
        public double CalculateSurfaceArea()
        {
            return (2 * (Math.PI * Math.Pow(radius, 2))) + 2 * radius * height;

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
        //Property definitions
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public override string ToString()
        {
            return "Cylinder" +
                   "\nRadius: " + radius +
                   "\nHeight: " + height +
                   "\nSurface Area: " + CalculateSurfaceArea().ToString("N2");
        }

    }
}
