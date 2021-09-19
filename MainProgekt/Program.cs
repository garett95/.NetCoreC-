using System;
using System.Collections;
using System.Collections.Generic;

namespace MainProgekt
{
    class Program
    {
        static void Main(string[] args)
        {
            AM_10();
            //List<int> pidr = new List<int>() { 1, 2, 5 };
            //pidr.Add(4);
            //pidr.Add(7);
            //pidr.AddRange(new int[] { 10, 12, 15 });
            //pidr.Sort();
            //pidr.RemoveAt(0);
            //Console.WriteLine($"sadfasd {pidr.IndexOf(4)}");
            //foreach (int i in pidr)
            //{
            //    Console.WriteLine(i);
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
        static void Show(double d)
        {
            Console.WriteLine($"{d}");
        }
        static void AM_10 ()
        {
            ArrayList animals = new ArrayList();
            animals.Add (new Cat() { Name = "Murka", Age = 5 });
            animals.Add (new Dog() { Age = 7, Name = "Bobick" });
            foreach (var i in animals)
            {
                Console.WriteLine(i);
            }
            //List<Cat> cats = new List<Cat>();
            //Cat cat = new Cat();
            //cat.Age = 2;
            //cat.Name = "Barsik";
            //Cat cat2 = new Cat() { Name = "Murka", Age = 5 };
            //cats.Add(cat);
            //cats.Add(cat2);
            //cats.Add(new Cat() { Name = "Murka", Age = 5 });
            //List<Dog> dogs = new List<Dog>();
            //dogs.Add(new Dog() { Age = 7, Name = "Bobick" });
            //Dog dog = new Dog();
            //dog.Name = "Grom";
            //dog.Age = 3;
            //dogs.Add(dog);
            //foreach (Cat i in cats)
            //{
            //    i.Show();
            //}
            //foreach (Dog i in dogs)
            //{
            //    i.Show();
            //}

        }

    }
}
