using System;

namespace Zadanie
{
    class Program
    {
        static void Main(string[] args)

        {
            int a, b, c;
            Console.WriteLine("Введите двузначное число:");
            a = Convert.ToInt32(Console.ReadLine());
            b = a / 10;
            c = a % 10;
            if (b > c)
            {
                Console.WriteLine($"Число {b} больше {c}");
            }
            else if (b < c)
            {
                Console.WriteLine($"Число {b} меньше {c}");
            }
            else
            {
                Console.WriteLine($"Число {b} равно {c}");
            }






        }


    }
}  
	

	
