using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortLab
{
    class Program
    {

        static void Main()
        {
            Sort();// сортировка
        }

        /*Основная программа*/
        static void Sort()
        {

            int[] myint = {
                99,
                88,
                77,
                66,
                55,
                44,
                33,
                22,
                11,
                8,
                5,
                3,
                1
            }; // объявление массива

            WriteArray(myint); // При переопределении в производном классе записывает массив в поток, уже подсоединенный к форматеру.
            ShakerSort(myint); // применение шейкер-сортировки
            WriteArray(myint); // При переопределении в производном классе записывает массив в поток, уже подсоединенный к форматеру.

            Console.ReadLine();

        }
        /* Шейкер-сортировка */
        static void ShakerSort(int[] myint)
        {
            int beg, end; // объявление локальных переменных целого типа
            int count = 0; // объявление локальной переменной целого типа

            for (int i = 0; i < myint.Length / 2; i++) //можно переберать за кол-во итераций, в 2 раза меньше
            { //целочисленное деление округляет в меньшую сторону
                beg = 0; // объявление переменной
                end = myint.Length - 1; // сдвиг позиции

                do
                {
                    count += 2;
                    /* идем спереди */
                    if (myint[beg] > myint[beg + 1]) Swap(myint, beg, beg + 1);
                    beg++; //сдвигаем позицию вперед

                    /* идем сзади */
                    if (myint[end - 1] > myint[end]) Swap(myint, end - 1, end);
                    end--; //сдвигаем позицию назад

                }
                while (beg <= end); // условия усреднения
            }
            Console.Write("\nКоличество сравнений = {0}\n", count); // вывод на экран строки "..." с указанными данными
        }

        /* Поменять элементы местами */
        static void Swap(int[] myint, int i, int j)
        {
            int glass; // объявление локальной переменной
            glass = myint[i]; // присвоение лок.переменной лок.переменную зависящую от i
            myint[i] = myint[j]; // присвоение лок.переменной лок.переменную зависящую от j 
            myint[j] = glass; // присвоение лок.переменной лок.переменную
        }

        /*Вывести массив*/
        static void WriteArray(int[] a)
        {
            foreach (int i in a) // применение оператора foreach, который перечисляет элементы коллекции и выполняет тело для каждого элемента коллекции
                Console.Write("{0}|", i); // вывод на экран строки с указанными данными
            Console.WriteLine("\n\n\n"); // вывод на экран строки с указанными данными
        }
    }
}