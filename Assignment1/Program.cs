using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, width;
            bool gotError = false;
            do
            {
                if (gotError)
                {
                    Console.Write("Wrong input, ");
                }
                Console.Write("Enter Length: ");
                gotError = true;
            } while (!int.TryParse(Console.ReadLine(), out length) || length <= 0);

            Console.WriteLine();

            gotError = false;
            do
            {
                if (gotError)
                {
                    Console.Write("Wrong input, ");
                }
                Console.Write("Enter Width: ");
                gotError = true;
            } while (!int.TryParse(Console.ReadLine(), out width) || width <= 0);


            var rectangle = new Rectangle(length,width);

            bool exitFlag = false;
            do
            {
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Lengh");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Perimeter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");

                

                int input;
                gotError = !int.TryParse(Console.ReadLine(), out input);
                if (gotError) continue;
                switch (input)
                {
                    case 1:
                        Console.WriteLine($"The Length of recrtangle is: {rectangle.GetLength()}");
                        break;
                    case 2:
                        gotError = false;
                        do
                        {
                            if (gotError)
                            {
                                Console.Write("Wrong input, ");
                            }
                            Console.Write("Enter Length: ");
                            gotError = true;
                        } while (!int.TryParse(Console.ReadLine(), out length) || length <= 0);
                        rectangle.SetLength(length);
                        break;
                    case 3:
                        Console.WriteLine($"The Width of recrtangle is: {rectangle.GetWidth()}");
                        break;
                    case 4:
                        gotError = false;
                        do
                        {
                            if (gotError)
                            {
                                Console.Write("Wrong input, ");
                            }
                            Console.Write("Enter Width: ");
                            gotError = true;
                        } while (!int.TryParse(Console.ReadLine(), out width) || width <= 0);
                        rectangle.SetWidth(width);
                        break;
                    case 5:
                        Console.WriteLine($"The Perimeter of recrtangle is: {rectangle.GetPerimeter()}");
                        break;
                    case 6:
                        Console.WriteLine($"The Area of recrtangle is: {rectangle.GetArea()}");
                        break;
                    case 7:
                        exitFlag = true;
                        break;
                    default:
                        Console.WriteLine("Wrong input, try again...");
                        break;
                }
                Console.WriteLine();
            } while (!exitFlag);

        }
    }
}
