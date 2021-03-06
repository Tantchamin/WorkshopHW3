using System;

namespace WorkshopHW3
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double p = Math.Pow(x - 1, 2);
            double t = Math.Sqrt(y) + 1;

            if (mode == "time" || mode == "price")
            {
                if (x < 0)
                {
                    Console.WriteLine("Invalid mouse position");
                }
                else
                {
                    if (mode == "time")
                    {
                        Console.WriteLine("{0}, {1}", x, p);
                    }
                    if (mode == "price")
                    {
                        Console.WriteLine("{0}, {1}", t, y);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid mode");
                if (x < 0)
                {
                    Console.WriteLine("Invalid mouse position");
                }
            }
        }
    }
}
