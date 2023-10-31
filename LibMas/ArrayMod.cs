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
        /// ��������� ������ ���������� ����������
        /// </summary>
        /// <param name="mas">������</param>
        public static void FillRandom(int[] mas)
        {
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next();
            }
        }

        /// <summary>
        /// ��������� ������ ���������� ����������
        /// </summary>
        /// <param name="mas">������</param>
        /// <param name="minValue">����������� ������� ���������</param>
        /// <param name="maxValue">������������ ������� ���������</param>
        public static void FillRandom(ref int[] mas, int minValue, int maxValue)
        {
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(minValue, maxValue);
            }
        }

        /// <summary>
        /// ������� ������
        /// </summary>
        /// <param name="mas">������</param>
        public static void ClearArray(ref int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = 0;
            }
        }

        /// <summary>
        /// ���������� ��� �������� �������
        /// </summary>
        /// <param name="mas">������</param>
        /// <returns>����� ���� ��������� �������</returns>
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
        /// ��������� ��� �������� �������, ������ ������������� �����
        /// </summary>
        /// <param name="mas">������</param>
        /// <param name="maxRange">������������ ��������</param>
        /// <returns>����� ����������</returns>
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
        /// ���������� �������� ������� � ������������� ���������
        /// </summary>
        /// <param name="mas">������</param>
        /// <param name="maxRange">������������ �������</param>
        /// <param name="minRange">����������� �������</param>
        /// <returns>����� ��������� �������</returns>
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
        /// ������������ ��� �������� ������� 
        /// </summary>
        /// <param name="mas">������</param>
        /// <returns>������������ ���� ��������� �������</returns>
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
        /// �������� ��� �������� �������, ������ ������������� �����
        /// </summary>
        /// <param name="mas">������</param>
        /// <param name="maxRange">������������ ��������</param>
        /// <returns>������������ ��������� �������</returns>
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
        /// ����������� �������� ������� � ������������ ���������
        /// </summary>
        /// <param name="mas">������</param>
        /// <param name="maxRange">������������ ��������</param>
        /// <param name="minRange">����������� ��������</param>
        /// <returns>������������ ��������� �������</returns>
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
        /// ���� ������������ ������� �������
        /// </summary>
        /// <param name="mas">������</param>
        /// <returns>������������ �������</returns>
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
        /// ���� ����������� ������� �������
        /// </summary>
        /// <param name="mas">������</param>
        /// <returns>����������� ��������</returns>
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
        /// ��������� ������ ���������� ����������
        /// </summary>
        /// <param name="mas">������</param>
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
        /// �������� ������
        /// </summary>
        /// <param name="mas">������</param>
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
        /// ��������� ���������� ������
        /// </summary>
        /// <param name="mas">������</param>
        public static void Save(int[,] mas)
        {
            SaveFileDialog save = new();
            save.DefaultExt = ".txt";
            save.Filter = "��� ����� (*.*) | *.* | ��������� ���� | .txt";
            save.FilterIndex = 2;
            save.Title = "��������� �������";

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
        /// ������� ���������� ������
        /// </summary>
        /// <returns>���������� ������</returns>
        public static int[,]? Open()
        {
            OpenFileDialog open = new();
            open.DefaultExt = ".txt";
            open.Filter = "��� ����� (*.*) | *.* | ��������� ���� | .txt";
            open.FilterIndex = 2;
            open.Title = "������� �������";

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
        /// ��������� ���������� ������
        /// </summary>
        /// <param name="mas">������</param>
        public static void Save(int[] mas)
        {
            SaveFileDialog save = new();
            save.DefaultExt = ".txt";
            save.Filter = "��� ����� (*.*) | *.* | ��������� ���� | .txt";
            save.FilterIndex = 2;
            save.Title = "��������� �������";

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
        /// ������� ���������� ������
        /// </summary>
        /// <returns>������</returns>
        public static int[]? Open1()
        {
            OpenFileDialog open = new();
            open.DefaultExt = ".txt";
            open.Filter = "��� ����� (*.*) | *.* | ��������� ���� | .txt";
            open.FilterIndex = 2;
            open.Title = "������� �������";

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
