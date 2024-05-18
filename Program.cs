using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace C_Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Label:
            while (i < 5)
            {
                Console.WriteLine("hello");
                i++;
                goto Label;
            }            

            bool condition = true;
            if(condition != true)
            {
                goto Label1;
            }

            Console.WriteLine("First line");

        Label1:
            Console.WriteLine("hello");

            int counter = 0;
            while(counter < 5) 
            {
                Console.Write("Счетчик {0} = {0}\n", counter); 
                counter++;  
                if(counter == 3)
                {
                    break;
                }
            }
            Console.WriteLine("Количество итераций равно {0}", counter);

            int count = 0;
            while (count < 5)
            {
                
                count++;
                if (count == 3)
                {
                    continue;
                }
                Console.Write("Счетчик {0} = {0}\n", count);
            }
            Console.WriteLine("Количество итераций равно {0}", count);


            Console.WriteLine("Угаждайте цвет с пяти попыток");
            Console.WriteLine("Для выхода из программы введите - exit");

            const int maxAttempt = 5; //Допустимое количество попыток
            int attempt = 0; //Счетчик попыток
            string color = "red"; //задуманный цвет

            while (attempt < maxAttempt)
            {
                attempt++;  
                Console.WriteLine("попытка {0}", attempt);

                string value = Console.ReadLine();
                if (value == "exit")
                {                   
                    break;
                }

                if(value != color)
                {
                    Console.WriteLine("Не угадал! Попробуй снова");
                    continue;
                }
                if(value == "red")
                {
                    Console.WriteLine("вы угадали с {0} попытки!", attempt);
                    break;
                }
            }

            int count1 = 0;
            do
            {
                count1++;
                Console.WriteLine("Значение счетчика {0}", count1);
            }
            while (count1 < 5);

            int count2 = 4;
            int factorial = 1;
            Console.Write("Факториал числа {0} = ", count2);
            do
            {
                factorial *= count2--;
            }
            while(count2 > 0);  
            Console.WriteLine("{0}", factorial);

            for(i = 0; i < 5; i++)
            {
                Console.WriteLine("Количестов итераций {0}", i);
            }
           
        }
    }
}
