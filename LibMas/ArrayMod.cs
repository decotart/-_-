using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.IO;
using System.Data;


namespace LibMasMain
{
    public class ArrayMod
    {
        /// <summary>
        /// Заполняет массив рандомными значениями
        /// </summary>
        /// <param name="mas">массив</param>
        public static void FillRandom(int[] mas)
        {
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next();
            }
        }

        /// <summary>
        /// Заполняет массив рандомными значениями
        /// </summary>
        /// <param name="mas">Массив</param>
        /// <param name="minValue">Минимальная граница диапазона</param>
        /// <param name="maxValue">Максимальная граница диапазона</param>
        public static void FillRandom(ref int[] mas, int minValue, int maxValue)
        {
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(minValue, maxValue);
            }
        }

        /// <summary>
        /// Очищает массив
        /// </summary>
        /// <param name="mas">массив</param>
        public static void ClearArray(ref int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = 0;
            }
        }

        /// <summary>
        /// Складывает все элементы массива
        /// </summary>
        /// <param name="mas">массив</param>
        /// <returns>сумма всех элементов массива</returns>
        public static int SummArray(int[] mas)
        {
            int sum = 0;
            foreach (int i in mas)
            {
                sum = sum + i;
            }
            return sum;
        }

        /// <summary>
        /// Складывет все элементы массива, меньше определенного числа
        /// </summary>
        /// <param name="mas">массив</param>
        /// <param name="maxRange">максимальное значение</param>
        /// <returns>сумма элемиентов</returns>
        public static int SummArray(int[] mas, int maxRange)
        {
            int sum = 0;
            foreach (int i in mas)
            {
                if (i < maxRange) sum = sum + i;
            }
            return sum;
        }

        /// <summary>
        /// Складывает элементы массива в определеннном диапазоне
        /// </summary>
        /// <param name="mas">массив</param>
        /// <param name="maxRange">максимальный элемени</param>
        /// <param name="minRange">минимальный элемент</param>
        /// <returns>сумма элементов массива</returns>
        public static int SummArray(int[] mas, int maxRange, int minRange)
        {
            int sum = 0;
            foreach (int i in mas)
            {
                if (i < maxRange && i > minRange) sum = sum + i;
            }
            return sum;
        }

        /// <summary>
        /// переменожает все элементы массива 
        /// </summary>
        /// <param name="mas">массив</param>
        /// <returns>произведение всех элементов массива</returns>
        public static int MultiplyArray(int[] mas)
        {
            int result = 1;
            foreach (int i in mas)
            {
                result = result * i;
            }
            return result;
        }

        /// <summary>
        /// Умножает все элементы массива, меньше определенного числа
        /// </summary>
        /// <param name="mas">массив</param>
        /// <param name="maxRange">максимальное значение</param>
        /// <returns>произведение элементов массива</returns>
        public static int MultiplyArray(int[] mas, int maxRange)
        {
            int result = 1;
            foreach (int i in mas)
            {
                if (i < maxRange) result = result * i;
            }
            return result;
        }

        /// <summary>
        /// перемножает элементы массива в определенном диапазоне
        /// </summary>
        /// <param name="mas">массив</param>
        /// <param name="maxRange">максимальное значение</param>
        /// <param name="minRange">минимальное знаечние</param>
        /// <returns>произведение элементов массива</returns>
        public static int MultiplyArray(int[] mas, int maxRange, int minRange)
        {
            int result = 1;
            foreach (int i in mas)
            {
                if (i < maxRange && i > minRange) result = result * i;
            }
            return result;
        }

        /// <summary>
        /// Ищет максимальный элемент массива
        /// </summary>
        /// <param name="mas">массив</param>
        /// <returns>максимальный элемент</returns>
        public static int GetMaxValue(int[] mas)
        {
            int value = mas[0];
            int max = mas[0];

            foreach (int i in mas)
            {
                if (i > value) max = i;
                value = i;
            }

            return max;
        }

        /// <summary>
        /// ищет минимальный элемент массива
        /// </summary>
        /// <param name="mas">массив</param>
        /// <returns>минимальное значение</returns>
        public static int GetMinValue(int[] mas)
        {
            int value = mas[0];
            int min = mas[0];

            foreach (int i in mas)
            {
                if (i < value) min = i;
                value = i;
            }

            return min;
        }

        /// <summary>
        /// Заполнить массив рандомными значениями
        /// </summary>
        /// <param name="mas">массив</param>
        public static void FillRandom(int[,] mas)
        {
            Random rnd = new Random();

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(1, 100);
                }
            }
        }

        /// <summary>
        /// очистить массив
        /// </summary>
        /// <param name="mas">массив</param>
        public static void Clear(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = 0;
                }
            }
        }

        /// <summary>
        /// Сохранить двухмерный массив
        /// </summary>
        /// <param name="mas">массив</param>
        public static void Save(int[,] mas)
        {
            SaveFileDialog save = new();
            save.DefaultExt = ".txt";
            save.Filter = "Все файлы (*.*) | *.* | Текстовые файл | .txt";
            save.FilterIndex = 2;
            save.Title = "Сохранить таблицу";

            if (save.ShowDialog() == true)
            {
                StreamWriter file = new(save.FileName);
                file.WriteLine(mas.GetLength(0));
                file.WriteLine(mas.GetLength(1));

                foreach (int i in mas)
                {
                    file.WriteLine(i);
                }
                file.Close();
            }
        }

        /// <summary>
        /// Открыть двухмерный массив
        /// </summary>
        /// <returns>двухмерный массив</returns>
        public static int[,]? Open()
        {
            OpenFileDialog open = new();
            open.DefaultExt = ".txt";
            open.Filter = "Все файлы (*.*) | *.* | Текстовые файл | .txt";
            open.FilterIndex = 2;
            open.Title = "Открыть таблицу";

            if (open.ShowDialog() == true)
            {
                StreamReader file = new(open.FileName);

                int length1 = Convert.ToInt32(file.ReadLine());
                int length2 = Convert.ToInt32(file.ReadLine());

                int[,] mas = new int[length1, length2];

                for (int i = 0; i < length1; i++)
                {
                    for (int j = 0; j < length2; j++)
                    {
                        mas[i, j] = Convert.ToInt32(file.ReadLine());
                    }
                }
                file.Close();
                return mas;
            }
            return null;

        }

        /// <summary>
        /// Сохранить одномерный массив
        /// </summary>
        /// <param name="mas">массив</param>
        public static void Save(int[] mas)
        {
            SaveFileDialog save = new();
            save.DefaultExt = ".txt";
            save.Filter = "Все файлы (*.*) | *.* | Текстовые файл | .txt";
            save.FilterIndex = 2;
            save.Title = "Сохранить таблицу";

            if (save.ShowDialog() == true)
            {
                StreamWriter file = new(save.FileName);
                file.WriteLine(mas.Length);

                foreach (int i in mas)
                {
                    file.WriteLine(i);
                }
                file.Close();
            }
        }

        /// <summary>
        /// Открыть одномерный массив
        /// </summary>
        /// <returns>массив</returns>
        public static int[]? Open1()
        {
            OpenFileDialog open = new();
            open.DefaultExt = ".txt";
            open.Filter = "Все файлы (*.*) | *.* | Текстовые файл | .txt";
            open.FilterIndex = 2;
            open.Title = "Открыть таблицу";

            if (open.ShowDialog() == true)
            {
                StreamReader file = new(open.FileName);

                int length = Convert.ToInt32(file.ReadLine());

                int[] mas = new int[length];

                for (int i = 0; i < length; i++)
                    mas[i] = Convert.ToInt32(file.ReadLine());

                file.Close();

                return mas;
            }
            return null;
        }
    }
}
