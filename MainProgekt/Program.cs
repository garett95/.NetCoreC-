using System;

namespace MainProgekt
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Ведите двузначное число");
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
    }
}
