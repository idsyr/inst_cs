using System;

namespace KR2
{
    class Program
    {
        static void Main(string[] args)
        {
            //EX1
            Console.WriteLine("___________________EX1___________________");
            Console.WriteLine("Hello, World!");
            var number = 5.5;
            number += 7;
            Console.WriteLine(number);

            //EX2
            Console.WriteLine("___________________EX2___________________");
            Console.WriteLine(GetMinX(1, 2, 3));
            Console.WriteLine(GetMinX(0, 3, 2));
            Console.WriteLine(GetMinX(1, -2, -3));
            Console.WriteLine(GetMinX(5, 2, 1));
            Console.WriteLine(GetMinX(4, 3, 2));
            Console.WriteLine(GetMinX(0, 4, 5));
            Console.WriteLine(GetMinX(0, 0, 2));
            Console.WriteLine(GetMinX(0, 0, 0));
            Console.WriteLine("");

            //EX3
            Console.WriteLine("___________________EX3___________________");
            Console.WriteLine("Скорость: 100");
            Console.WriteLine("Дистанция: 1000");
            Console.WriteLine("Угол: " + findAngleBirds(100.0, 1000.0));
            Console.WriteLine("");

            //EX4
            Console.WriteLine("___________________EX4___________________");
            Console.WriteLine("initialDirection: 45");
            Console.WriteLine("wallInclination: 90");
            Console.WriteLine("expectedFinalDirection: " + findAngleBilliard(45, 90));
            Console.WriteLine("");

            //EX5
            Console.WriteLine("___________________EX5___________________");
            Console.WriteLine("Введите исходную сумму, процентную ставку (в процентах, и срок вклада в месяцах)");
            string dataContribution = Console.ReadLine();
            Console.WriteLine("Накопленная сумма равна: " + Calculate(dataContribution));
        }


        private static string GetMinX(double a, double b, double c)
        {
            if (a == 0 && b == 0)
            {
                return "0";
            }
            if (a > 0)
            {
                return (-b / (2.0 * a)).ToString();
            }
            else
            {
                return "Impossible";
            }
        }


        public static double findAngleBirds(double v, double distance)
        {
            double g = 9.8;
            return Math.Asin(distance * g / (v * v)) / 2;
        }


        public static double findAngleBilliard(double initialDirection, double wallInclination)
        {
            return 2 * wallInclination - initialDirection;
        }


        public static double Calculate(string data)
        {
            string[] sortData = data.Split(' ');
            double sum = Convert.ToDouble(sortData[0]);
            double percent = Convert.ToDouble(sortData[1]);
            double months = Convert.ToDouble(sortData[2]);
            return sum * Math.Pow(1 + percent / 1200, months);
        }




    }
}