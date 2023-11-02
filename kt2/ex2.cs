using System;

namespace Циклы
{
    class Program
    {
        static void Main()
        {
            //EX1
            Console.WriteLine("____________________EX1:____________________");
            Console.WriteLine(GetMinPowerOfTwoLargerThan(2));
            Console.WriteLine(GetMinPowerOfTwoLargerThan(15));
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-2));
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-100));
            Console.WriteLine(GetMinPowerOfTwoLargerThan(100));
            Console.WriteLine("");

            //EX2
            Console.WriteLine("____________________EX2:____________________");
            Console.WriteLine(RemoveStartSpaces("a"));
            Console.WriteLine(RemoveStartSpaces(" b"));
            Console.WriteLine(RemoveStartSpaces(" cd"));
            Console.WriteLine(RemoveStartSpaces(" efg"));
            Console.WriteLine(RemoveStartSpaces(" text"));
            Console.WriteLine(RemoveStartSpaces(" two words"));
            Console.WriteLine(RemoveStartSpaces(" twospaces"));
            Console.WriteLine(RemoveStartSpaces(" tabs"));
            Console.WriteLine(RemoveStartSpaces(" twotabs"));
            Console.WriteLine(RemoveStartSpaces("many spaces"));
            Console.WriteLine(RemoveStartSpaces(""));
            Console.WriteLine(RemoveStartSpaces("\n\r linebreaks are spaces too"));
            Console.WriteLine("");

            //EX3
            Console.WriteLine("____________________EX3:____________________");
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");
            Console.WriteLine("");

            //EX4
            Console.WriteLine("____________________EX4:____________________");
            WriteBoard(8);
            WriteBoard(1);
            WriteBoard(2);
            WriteBoard(3);
            WriteBoard(10);
            Console.WriteLine("");

            //EX5
            Console.WriteLine("____________________EX5:____________________");
            Console.WriteLine("Для задач 5, 6, 7 имеются смежные функции, функция MoveOut для задачи 5 - MoveOut1");
            Console.WriteLine("");

            //EX6
            Console.WriteLine("____________________EX6:____________________");
            Console.WriteLine("Функции для решения задач Лабиринта представлены в строках 122 - 198. функция MoveOut для задачи 6 - MoveOut2");
            Console.WriteLine("");

            //EX7
            Console.WriteLine("____________________EX7:____________________");
            Console.WriteLine("функция MoveOut для задачи 7 - MoveOut3");
            Console.WriteLine("");

            //EX8
            Console.WriteLine("____________________EX8:____________________");
            Console.WriteLine("Строки 200 - 230");
            Console.WriteLine("");
        }

        private static int GetMinPowerOfTwoLargerThan(int number)
        {
            int result = 0;
            int i = 0;
            while(result<=number)
            {
                i++;
                result = (int)Math.Pow(2, i);
            }
            
            return result;
        }

        public static string RemoveStartSpaces(string text)
        {
            while (text.Length > 0 && char.IsWhiteSpace(text[0]))
            {
                text = text.Substring(1);
            }
            return text;
        }

        private static void WriteBoard(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                    Console.Write(i % 2 + j % 2 == 1 ? "." : "#");

                Console.WriteLine();
            }

            Console.WriteLine();
        }
        private static void WriteTextWithBorder(string text)
        {
            string line = "";

            for (int i = 0; i < text.Length + 4; i++)
            {
                if (i == 0 || i == text.Length + 3)
                    line += "+";
                else
                    line += "-";
            }

            Console.WriteLine(line);
            Console.WriteLine("| " + text + " |");
            Console.WriteLine(line);
            Console.WriteLine("");
        }
        /*
        public static void MoveOut1(Robot robot, int width, int height)
        {
            MoveRight(robot, width - 2);
            MoveDown(robot, height - 2);
        }

        public static void MoveRight(Robot r, int steps)
        {
            for (int i = 1; i < steps; i++)
                r.MoveTo(Direction.Right);
        }


        public static void MoveDown(Robot r, int steps)
        {
            for (int i = 1; i < steps; i++)
                r.MoveTo(Direction.Down);
        }

        public static void MoveOut2(Robot robot, int width, int height)
        {
            int down = (height - 2) / 2;

            for (int i = 0; i <= down; i++)
            {
                MoveSnake(robot, i, width - 2);

                if (i != down) MoveDown(robot, 3);
            }
        }

        public static void MoveSnake(Robot r, int i, int steps)
        {
            if (i % 2 == 0) MoveRight(r, steps);
            else MoveLeft(r, steps);
        }



        public static void MoveLeft(Robot r, int steps)
        {
            for (int i = 1; i < steps; i++)
                r.MoveTo(Direction.Left);
        }

        public static void MoveOut3(Robot robot, int width, int height)
        {
            width -= 2;
            height -= 2;

            if (height < width)
                DiagonalMoveFromRight(robot, 2, width / height + 1, height);
            else
                DiagonalMoveFromDown(robot, (int)System.Math.Round((double)height / width) + 1, 2, width);
        }

        public static void DiagonalMoveFromDown(Robot r, int intervalDown, int intervalRight, int end)
        {
            for (int i = 0; i < end; i++)
            {
                MoveDown(r, intervalDown);

                if (i != end - 1)
                    MoveRight(r, intervalRight);
            }
        }

        public static void DiagonalMoveFromRight(Robot r, int intervalDown, int intervalRight, int end)
        {
            for (int i = 0; i < end; i++)
            {
                MoveRight(r, intervalRight);

                if (i != end - 1)
                    MoveDown(r, intervalDown);
            }
        }

        public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
        {
            double a1 = Math.PI * 45 / 180;
            double a2 = Math.PI * 135 / 180;

            double x = 1.0;
            double y = 0.0;

            Random r = new Random(seed);

            for (int i = 0; i < iterationsCount; i++)
            {
                double newX;
                double newY;

                if (r.Next(2) == 0)
                {
                    newX = (x * Math.Cos(a1) - y * Math.Sin(a1)) / Math.Sqrt(2);
                    newY = (x * Math.Sin(a1) + y * Math.Cos(a1)) / Math.Sqrt(2);
                }
                else
                {
                    newX = (x * Math.Cos(a2) - y * Math.Sin(a2)) / Math.Sqrt(2) + 1;
                    newY = (x * Math.Sin(a2) + y * Math.Cos(a2)) / Math.Sqrt(2);
                }

                x = newX;
                y = newY;

                pixels.SetPixel(x, y);
            }
        */
    }
}
