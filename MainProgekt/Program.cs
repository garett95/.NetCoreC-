using System;

namespace MainProgekt
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //string[] a = new string[2];
            //a[0] = "Азнив";
            //a[1] = "Кот";
            //Console.WriteLine($"{a[0]}");
            //Console.WriteLine(a[1]);
            //char[] b = new char[3];
            //for (int i = 0; i < b.Length; i++)
            //{
            //    Console.Write($"b[{i}] равно ");
            //    b[i] = Convert.ToChar(Console.ReadLine());
            //}
            //for (int i = 1; i < b.Length; i++)
            //{
            //    Console.Write($"{b[i]} ");
            //}

            //Console.WriteLine("Введите элементы массива");

            //for (int i = 0; i < b.Length; i++)
            //{
            //    Console.Write($"b[{i}] = ");
            //    b[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < b.Length; i++)
            //{
            //    Console.Write($"{b[i]} ");
            //}
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
        static void Show()
        {
            Console.WriteLine($"");
        }
        static void AM_9()
        {
            Car car1 = new Car();
            Car car2 = new Car();
            car1.Input();
            car2.Input();
            Car[] cars = new Car[2];
            cars[0] = car1;
            cars[1] = car2;
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].Show();
            }
        }
    }
}
