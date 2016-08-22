/*ClassCreationExercise.cs
 * This program contains four
 * classes. Three classes define types of objects. 
 * The fourth class is displays a menu of shapes,
 * instantiates the objects and displays the dimensions.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureApp
{
    class FigureApp
    {
        private static string selection;
        static void Main(string[] args)
        {
            Console.Write("You will be asked to select a figure and then enter dimensions of that figure."
            + "\nThe area of that figure will be displayed.\n\n");

            selection = DisplayMenu();
            CreateShape(selection);
            Console.WriteLine("Press any key to see the next test...");
            Console.ReadKey();

            Console.Clear();
            selection = DisplayMenu();
            CreateShape(selection);
            Console.WriteLine("Press any key to see the next test...");
            Console.ReadKey();

            Console.Clear();
            selection = DisplayMenu();
            CreateShape(selection);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }



        static string DisplayMenu()
        {
            string figureChosen;
            char choice;
            Console.Write(
                "\nPlease select a figure by using the following options:\n" +
                "\n\tCIRCLE.......enter 'C'\n\t" +
                "RECTANGLE....enter 'R'\n\t" +
                "CYLINDER.....enter 'Y'\n\n" +
                "Enter your choice here: ");
            choice = char.Parse(Console.ReadLine());

            switch (choice)
            {
                case 'c':
                case 'C': figureChosen = "circle";
                    break;
                case 'r':
                case 'R': figureChosen = "rectangle";
                    break;
                case 'y':
                case 'Y': figureChosen = "cylinder";
                    break;
                default: figureChosen = "UNACCEPTABLE INPUT";
                    break;
            }

            return figureChosen;
        }

        public static void CreateShape(string selection)
        {
            if (selection == "circle")
            {
                Circle aCircle = new Circle();
                aCircle.Radius = 45;
                Console.WriteLine(aCircle);
            }

            else
                if (selection == "rectangle")
                {
                    Rectangle aRect = new Rectangle();
                    aRect.Length = 14;
                    aRect.Width = 12;
                    Console.WriteLine(aRect);
                }
                else
                {
                    if (selection == "cylinder")
                    {
                        Cylinder aCyl = new Cylinder();
                        aCyl.Height = 20;
                        aCyl.Radius = 7;
                        Console.WriteLine(aCyl);
                    }
                    else
                        Console.WriteLine(selection);

                }
        }
    }
}

