using System;
using System.Collections.Generic;

namespace MainProgekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //0.0, 6.0, 3,6
            
            var triangle1 = new Triangle();
            triangle1.A = new Point { X = 0, Y = 0 };
            triangle1.B = new Point { X = 6, Y = 0 };
            triangle1.C = new Point { X = 3, Y = 6 };
            var D = new Point{ X = 0, Y = 0 };
            Console.WriteLine(triangle1);

        }
        static void AM_2()
        {
            int a, b, c, d;
            Console.WriteLine("Введите двузначное число");
            a = Convert.ToInt32(Console.ReadLine());
            b = a / 10;
            c = a % 10;
            if ((b + c) % 3 == 0)
            {
                Console.WriteLine("Сумма цифр кратна трем");
            }
            else
            {
                Console.WriteLine("Сумма цифр не кратна трем");
            }
            Console.WriteLine("Ведите число d");
            d = Convert.ToInt32(Console.ReadLine());
            if ((b + c) % d == 0)
            {
                Console.WriteLine($"Сумма цифр кратна {d}");
            }
            else
            {
                Console.WriteLine($"Сумма цифр не кратна {d}");
            }
        }
        static void AM_3()
        {
            int a, b, c, d;
            Console.WriteLine("Введите двузначное число");
            a = Convert.ToInt32(Console.ReadLine());
            b = a / 10;
            c = a % 10;
            Console.WriteLine("Ведите число d");
            d = Convert.ToInt32(Console.ReadLine());
            if (b == d || c == d)
            {
                Console.WriteLine($"В число {a} входит цифра {d}");
            }
            else
            {
                Console.WriteLine($"В число {a} не входит цифра {d}");
            }
        }
        static void AM_4()
        {
            Console.WriteLine("Привет, мир");
        }
        static void AM_5(int a)
        {
            Console.WriteLine(a * a);
        }
        static int AM_6(int a)
        {
            return (a * a);
        }
        static double AM_7(double a, double b, char c)
        {
            double d = 0;
            if (c == '-')
            {
                d = a - b;
            }
            else if (c == '+')
            {
                d = a + b;
            }
            else if (c == '*')
            {
                d = a * b;
            }
            else if (c == '/')
            {
                d = a / b;
            }
            else
            {
                Console.WriteLine(".!.");
            }
            return d;
        }
        static void Show(double d)
        {
            Console.WriteLine($"{d}");
        }
    }
}
