using System;

namespace KR1
{
    class Program
    {
        static int Main(string[] args)
        {
            //EX1
            Console.WriteLine("____________________EX1:____________________");
            double num1 = +5.5e-2;
            float num2 = 7.8f;
            int num3 = 0;
            long num4 = 2000000000000L;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine("");

            //EX2
            Console.WriteLine("____________________EX2:____________________");
            double pi = Math.PI;
            long tenThousand = 10000L;
            float tenThousandPi = (float)pi * tenThousand;
            int roundedTenThousandPi = (int)Math.Round(tenThousandPi);
            int integerPartOfTenThousandPi = (int)tenThousandPi;
            Console.WriteLine(integerPartOfTenThousandPi);
            Console.WriteLine(roundedTenThousandPi);
            Console.WriteLine("");

            //EX3
            Console.WriteLine("____________________EX3:____________________");
            double amount = 1.11;
            int peopleCount = 60;
            int totalMoney = (int)Math.Round(amount * peopleCount);
            Console.WriteLine(totalMoney);
            Console.WriteLine("");

            //EX4
            Console.WriteLine("____________________EX4:____________________");
            string doubleNumber = "894376,243643";
            double number = Convert.ToDouble(doubleNumber);
            Console.WriteLine(number + 1);
            Console.WriteLine("");

            //EX5
            Console.WriteLine("____________________EX5:____________________");
            var a = 5.0;
            a += 0.5;
            Console.WriteLine(a);
            Console.WriteLine("");

            //EX6
            Console.WriteLine("____________________EX6_____________________");
            Console.WriteLine(GetGreetingMessage("Student", 10.01));
            Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
            Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));
            Console.WriteLine("");

            //EX7
            Console.WriteLine("____________________EX7_____________________");
            Print(GetSquare(42));
            Console.WriteLine("");

            //EX8
            Console.WriteLine("____________________EX8_____________________");
            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));

            return 0;
        }


        private static string GetGreetingMessage(string name, double salary)
        {
            return "Hello, " + name.ToString() + ", your salary is " + Math.Ceiling(salary).ToString();
        }


        private static void Print(int a)
        {
            Console.WriteLine(a);
        }


        private static int GetSquare(int a)
        {
            return a * a;
        }


        private static string GetLastHalf(string text)
        {
            return text.Substring(text.Length / 2).Replace(" ", "");
        }

    }

}