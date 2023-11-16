// See https://aka.ms/new-console-template for more information
using System;


//Завдання 1
//Створіть набір методів для роботи з масивами:
//■ Метод для отримання усіх парних чисел у масиві;
//■ Метод для отримання усіх непарних чисел у масиві;
//■ Метод для отримання усіх простих чисел у масиві;
//■ Метод для отримання усіх чисел Фібоначчі в масиві.
//Використовуйте механізми делегатів


class Program
{

    delegate bool MDA(int number);
    static void Print(int[] numbers, MDA t3)
    {
        foreach (var number in numbers)
        {
            if (t3.Invoke(number))
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }

    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static bool IsOdd(int number)
    {
        return number % 2 != 0;
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static bool IsFibonacci(int number)
    {
        int a = 0, b = 1;
        while (b < number)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return b == number;
    }


    static void Main()
    {
        MDA[] dg = { IsEven, IsOdd, IsPrime, IsFibonacci };
        int[] MyArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        int choice = 0;
        Console.WriteLine("Масив для фильтрування: ");
        foreach (var i in MyArr)
        {
            Console.Write($"{i} ");
        };
        Console.WriteLine();

        while (choice != 5)
        {
            Console.Write("\n1 IsEven \n2 IsOdd \n3 IsPrime \n4 IsFibonacci \n5 Exit\nYour choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice >= 1 && choice <= 4)
            {
                Print(MyArr, dg[choice - 1]);

            }

        }




    }
}
  
