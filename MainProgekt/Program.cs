using System;

namespace MainProgekt
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            long tenThousand = 10000L;
            long tenThousandPi = (long)pi * tenThousand;
            int roundedTenThousandPi = (int) Math.Round ((double)tenThousandPi);
            int integerPartOfTenThousandPi = (int) tenThousandPi;
            Console.WriteLine(integerPartOfTenThousandPi);
            Console.WriteLine(roundedTenThousandPi);
            //Student azniv1 = new Student(); //создание экземпляра класса азнив1 это экземпляр 
            //azniv1.age = 64;    //обращаемся к полю экземпляра класса 64 это не срок 
            //azniv1.firstName = "Asik"; 

            //Student azniv2 = new Student();
            //azniv2.age = 24;
            //azniv2.firstName = "asdasfds";

            //Student[] students = new Student[2]; //создаем массив, student - тип массива, students - название массива
            //students[0] = azniv1;
            //students[1] = azniv2;
            ////Console.WriteLine($"Имя - {students[0].firstName}, возраст - {students[0].age}");
            ////Console.WriteLine($"Имя - {students[1].firstName}, возраст - {students[1].age}");
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine($"Имя - {students[i].firstName}, возраст - {students[i].age}");
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
    }
}
