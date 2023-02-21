using System;

namespace Program
{
    partial class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var num = int.Parse("abv");       //Try.Parse doesnt throw an exception


            }
            catch (Exception)
            {
                Console.WriteLine("conversion failed");
            }

            //var number = int.Parse("abc");
            int number;
            var result = int.TryParse("abv", out number);       //Try.Parse doesnt throw an exception
            if (result)
            {
                Console.WriteLine(number);
            }
            else
                Console.WriteLine("conversion failed");
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 7, 3));
            Console.WriteLine(calculator.Add(new int[] { 2, 4, 5, 6, 74 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("New point: {0}, {1}", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("point is at {0}, {1} ", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
                throw;
            }
        }

    }
}