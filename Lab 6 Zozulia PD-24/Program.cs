using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6_Zozulia_Roman_PD_24
{
    class Program
    {
        static void Main(string[] args)
        {

            // 7.Створити ліст інтових змінних, який може містити тільки прості числа.
            //Порахувати кількість повторень кожного простого числа. Скопіювати
            //отриманий ліст в масив.

            List<int> numbers = new List<int>() { 11, 77, 33, 77, 45, 77, 95 };

            int[] array = new int[7];



            //Копіюємо ліст в масив 
            for (int i = 0; i < array.Length; i++)
            {
                numbers.CopyTo(array);
            }


            //Рахуємо к-ть повторів числа 
            int kilkist_povtoriv_chisel = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1 + i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        kilkist_povtoriv_chisel++;
                    }
                }
            }

            //Вивід масиву і к-ть повторів 
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine($"Count povtoriv  {kilkist_povtoriv_chisel}");


        }
    }
}
