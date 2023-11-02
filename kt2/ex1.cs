using System;

namespace Ветвления
{
    class Program
    {
        public static void Main()
        {
            //EX1
            Console.WriteLine("____________________EX1:____________________");
            Console.WriteLine(IsLeapYear(2014));
            Console.WriteLine(IsLeapYear(1999));
            Console.WriteLine(IsLeapYear(8992));
            Console.WriteLine(IsLeapYear(1));
            Console.WriteLine(IsLeapYear(14));
            Console.WriteLine(IsLeapYear(400));
            Console.WriteLine(IsLeapYear(600));
            Console.WriteLine(IsLeapYear(3200));
            Console.WriteLine("");

            //EX2
            Console.WriteLine("____________________EX2:____________________");
            TestMove("a1", "d4");
            TestMove("f4", "e7");
            TestMove("a1", "a4");
            Console.WriteLine("");

            //EX3
            Console.WriteLine("____________________EX3:____________________");
            Console.WriteLine(MiddleOf(5, 0, 100)); // => 5
            Console.WriteLine(MiddleOf(12, 12, 11)); // => 12
            Console.WriteLine(MiddleOf(1, 1, 1)); // => 1
            Console.WriteLine(MiddleOf(2, 3, 2));
            Console.WriteLine(MiddleOf(8, 8, 8));
            Console.WriteLine(MiddleOf(5, 0, 1));
            Console.WriteLine("");

            //EX4
            Console.WriteLine("____________________EX4:____________________");
            bool enemyInFront = true;
            string enemyName = "unit_1";
            int robotHealth = 25;
            Console.WriteLine("enemyInFront: {0}", enemyInFront);
            Console.WriteLine("enemyName: {0}", enemyName);
            Console.WriteLine("robotHealth: {0}", robotHealth);
            Console.WriteLine("ShouldFire: {0}", ShouldFire(enemyInFront, enemyName, robotHealth));
            Console.WriteLine("");

            //EX5
            Console.WriteLine("____________________EX5:____________________");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i + " " + PluralizeRubles(i));
            }
            Console.WriteLine("");

            //EX6
            Console.WriteLine("____________________EX6:____________________");
            Console.WriteLine("Строки 115 - 143");
            Console.WriteLine("");

            //EX7
            Console.WriteLine("____________________EX6:____________________");
            Console.WriteLine("Строки 144 - 158");
            Console.WriteLine("");
        }

        public static bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);
        }

        public static void TestMove(string from, string to)
        {
            Console.WriteLine("{0}-{1} {2}", from, to,
            IsCorrectMove(from, to));
        }

        public static bool IsCorrectMove(string from, string to)
        {
            if (from == to) return false;
            if (from[0] == to[0] && from[1] != to[1]) return true;
            if (from[1] == to[1] && from[0] != to[0]) return true;
            if (from[1] != to[1] && from[0] != to[0])
            {
                if (Math.Abs(from[0] - to[0]) == Math.Abs(from[1] - to[1]))
                    return true;
                else return false;
            }
            return false;
        }

        public static int MiddleOf(int a, int b, int c)
        {
            int[] abc = new int[] { a, b, c };
            Array.Sort(abc);
            return abc[1];
        }

        public static bool ShouldFire(bool enemyInFront, string enemyName, int robotHealth)
        {
            return enemyInFront && (enemyName == "boss" && robotHealth >= 50) || enemyName != "boss";
        }

        public static string PluralizeRubles(int count)
        {
            int a = count % 10;
            int b = count > 10 ? count % 100 : 0;

            if ((b >= 10 && b < 20) || a == 0 || a > 4) return "рублей";
            else if (a > 1 && a < 5) return "рубля";
            else return "рубль";
        }

       /* public static bool AreIntersected(Rectangle r1, Rectangle r2)
        {
            return r1.Left <= r2.Right && r1.Right >= r2.Left && r1.Bottom >= r2.Top && r1.Top <= r2.Bottom;
        }

        public static int IntersectionSquare(Rectangle r1, Rectangle r2)
        {
            int left = Math.Max(r1.Left, r2.Left);
            int top = Math.Max(r1.Top, r2.Top);
            int right = Math.Min(r1.Right, r2.Right);
            int bottom = Math.Min(r1.Bottom, r2.Bottom);

            int width = right - left;
            int height = bottom - top;

            if ((width < 0) || (height < 0)) return 0;

            return width * height;
        }

        public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
        {
            if (r1.Left >= r2.Left && r1.Right <= r2.Right && r1.Bottom <= r2.Bottom && r1.Top >= r2.Top) return 0;

            if (r2.Left >= r1.Left && r2.Right <= r1.Right && r2.Bottom <= r1.Bottom && r2.Top >= r1.Top) return 1;

            return -1;
        } */

        public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
        {
            if (ax == bx && ay == by)
            {
                return Math.Sqrt((x - ax) * (x - ax) + (y - ay) * (y - ay));
            }
            else if (((x - ax) * (bx - ax) + (y - ay) * (by - ay)) < 0 || ((x - bx) * (ax - bx) + (y - by) * (ay - by)) < 0)
            {
                return Math.Min(Math.Sqrt((x - ax) * (x - ax) + (y - ay) * (y - ay)), Math.Sqrt((x - bx) * (x - bx) + (y - by) * (y - by)));
            }
            else
            {
                return Math.Abs((bx - ax) * (y - ay) - (by - ay) * (x - ax)) / Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
            }
        }
    }


}
