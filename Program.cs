using System;

namespace CW._28._03
{
    class Program
    {
        static void Main(string[] args)
        {
            string dannoeSlovo = "вода";
            int countOfTry = 5;
            do
            {
                System.Console.WriteLine($"У вас осталось {countOfTry} попыток!");
                System.Console.Write("Угадайте загадку 'Что течет?' : ");
                if(Console.ReadLine().ToLower() != dannoeSlovo)
                {
                    countOfTry--;
                    
                    Console.Clear();
                }
                else {
                    System.Console.Write("Поздравляю вы угадали!");
                    break;
                }
            }            
            while(countOfTry != 0);
            System.Console.WriteLine("\n");
            System.Console.Write("Введите число А: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.Write("Введите число B: ");
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = a; i <= b; i++)
            {
                sum += i;
            }
            System.Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
