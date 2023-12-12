using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aboba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie_4();
        }

        private static void Zadanie_1()
        {
            int[] array = { 6, 23, 3, 8, 19, 54, 21, 666, 7, 8734, 5, 2, 111, 78, 96 };

            int Chet = 0;
            int Nechet = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Chet++;
                }
                else if (array[i] % 2 != 0)
                {
                    Nechet++;
                }
            }


            Console.WriteLine("Количество четных элементов: " + Chet);
            Console.WriteLine("Количество нечетных элементов: " + Nechet);

            Console.ReadLine();
        }


        private static void Zadanie_2()
        {
            Console.WriteLine("Введите размер массива:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];
            Console.WriteLine("Введите размер чисел:");

            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введите значение для фильтрации:");
            int filterValue = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            foreach (int num in array)
            {
                if (num < filterValue)
                {
                    count++;
                }
            }

            Console.WriteLine("Количество значений меньше " + filterValue + " : " + count);
        }
        private static void Zadanie_3()
        {
            int[] array = { 17, 62, 5, 34, 4, 7, 76, 5, 89, 7, 6, 5, 4, 4 };

            Console.WriteLine("Введите три числа:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < array.Length - 2; i++)
            {
                if (array[i] == num1 && array[i + 1] == num2 && array[i + 2] == num3)
                {
                    count++;
                }
            }

            Console.WriteLine("Количество повторений последовательности: " + count);
        }
        private static void Zadanie_4()
        {
            int[] M = { 17, 2, 23, 4, 6, 14, 89, 25, 876};
            int[] N = { 36, 4, 53, 6, 17, 236, 78, 25, 14 };


            int[] commonElements = M.Intersect(N).Distinct().ToArray();

            Console.WriteLine("Общие элементы без повторений:");
            foreach (var element in commonElements)
            {
                Console.WriteLine(element);
            }

        }
    }
}
    




