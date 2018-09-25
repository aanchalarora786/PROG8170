using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFO8170_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            /// calling variables of rectangle class
            int rectlength = rectangle.Length;
            int rectwidth = rectangle.Width;

            Console.WriteLine("Enter the Length of Rectangle");
            string length = string.Empty;
            length = Console.ReadLine();
            //parsing  to int
            rectlength = int.Parse(length);
            Console.WriteLine("Enter the Width of Rectangle");
            string width = string.Empty;
            width = Console.ReadLine();
            // /// parsing to int
            rectwidth = int.Parse(width);
            string userinput = string.Empty;
            bool validMenuSelection = false;
            while (validMenuSelection == false)
            {



                Console.WriteLine("1 Get Rectangle Length");
                Console.WriteLine("2 Change Rectangle Length");
                Console.WriteLine("3 to Get Rectangle Width");
                Console.WriteLine("4 to Change Rectangle Width");
                Console.WriteLine("5 to Get Rectangle Parameter");
                Console.WriteLine("6 to Get Rectangle Area");
                Console.WriteLine("7 to Exit");

                userinput = Console.ReadLine();

                switch (userinput)
                {
                    case "1":
                        Console.WriteLine("Length of the Rectangle is {0} ", rectangle.SetLength(rectlength));

                        break;
                    case "2":
                        Console.WriteLine("Enter new Length");
                        length = Console.ReadLine();
                        rectlength = int.Parse(length);
                        Console.WriteLine("new length is {0} ", rectangle.SetLength(rectlength));
                        break;
                    case "3":
                        Console.WriteLine("width is {0} ", rectangle.GetWidth());
                        break;
                    case "4":
                        Console.WriteLine("Enter new width");
                        width = Console.ReadLine();
                        rectwidth = int.Parse(width);
                        Console.WriteLine("new width is {0} ", rectangle.SetWidth(rectwidth));
                        break;
                    case "5":
                        Console.WriteLine("perimeter is {0} ", rectangle.GetPerimeter());
                        break;
                    case "6":
                        Console.WriteLine("Area is {0} ", rectangle.GetArea());
                        break;
                    case "7":
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("please enter correctly");
                        break;
                }
            }
        }
    }
}
