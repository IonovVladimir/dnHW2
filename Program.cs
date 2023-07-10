using System;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        

        int Input(string text)
        {
            Console.Write(text); ///line начнёт с новой строки
            return Convert.ToInt32(Console.ReadLine());          
        }

        void Task10()
        {
            //Напишите программу, которая на вход принимает трёхзначное число,
            //а на выходе показывает вторую цифру этого числа
            Console.WriteLine("Vvedi chislo:");
            int number= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"chislo= {number}");
            int f_number = number / 100;
            int d_number= number-f_number * 100;
            int s_number= d_number / 10;
            //Console.WriteLine($"1 chislo= {f_number}");
            Console.WriteLine($"2 chislo= {s_number}");
            //Console.WriteLine($"3 chislo= {t_number}");
        }
        //Task10();

        void Task13()
        {
            //Напишите программу, которая с помощью деления выводит третью
            //цифру заданного числа или сообщает, что третьей цифры нет.
            int number = Input("vvedi chislo: ");


            if (number / 100 == 0)
            {
                Console.WriteLine($"нет");
            }
            else if (number / 1000 == 0) Console.WriteLine($"{number % 100%10}");
            else if (number / 1000 > 0)
            {
                while (number / 1000 > 0) 
                { 
                    number = number / 10;
                }
                Console.WriteLine($"{number%10}");                             
            }

            //Console.WriteLine($"Третья цифра: {number}");
        }
        Task13();
       //Console.WriteLine("Hello, World!");

        void Task15() 
        {
            int a_day = Input("Введи номер дня недели: ");
            if (a_day != 6 && a_day != 7)
            {
                Console.WriteLine("Будни");
            }
            else Console.WriteLine("ВЫХОДНОЙ!!!");
        }
        //Task15();

        void Test()
        {
            int number = Input("Chislo=");
            //Console.WriteLine($"{number/10}");
            //Console.WriteLine($"{number % 10}");

            while (number/100 > 0) 
            {
            number= number/100;
            }
            Console.WriteLine($"{number % 10}");

        }
        //Test();
    }
}