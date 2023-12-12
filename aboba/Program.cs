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
            Zadanie_1();
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

        }
    }

}


