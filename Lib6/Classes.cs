using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Documents;

namespace Lib_6_version_2._0_
{
    public class Work1
    {
        /// <summary>
        /// Генерировать случайные числа от -5 до 4. для чисел < 0 высчитать вторую степень, числа > 0 возвести в квадратный корень.
        /// </summary>
        /// <param name="count">Количество случайных чисел</param>
        /// <param name="values">Сгенерированные числа</param>
        /// <param name="results">Результаты вычислений</param>
        public static void Function1(ref string values, ref string results)
        {
            Random rnd = new Random();
            double value, lastValue = 7;

            while (true)
            {
                value = rnd.Next(-5, 5);
                values = values + value + "; ";

                if (value > 0) value = Math.Round(Math.Sqrt(value), 2);
                else value = Math.Pow(value, 2);

                results = results + value + "; ";

                if (value == lastValue) break;
                lastValue = value;
            }

        }
    }

    public static class Work2
    {
        /// <summary>
        /// Вычисляет сумму элементов массива, меньших чем определенное число
        /// </summary>
        /// <param name="mas">массив</param>
        /// <param name="maxValue">мксимальное значение</param>
        /// <returns>Сумма элементов массива</returns>
        public static int SummArray(int[] mas, int maxValue)
        {
            int sum = 0;
            foreach (int i in mas)
            {
                if (i < maxValue)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }

    public static class Work3
    {
        /// <summary>
        /// сумму элементов для каждого четного столбца матрицы
        /// </summary>
        /// <param name="mas">двухмерный массив</param>
        /// <returns>суммы элементов четных столбцов матрицы </returns>
        public static int[] Function3(int[,] mas)
        {
            int[] result = new int[(mas.GetLength(0) / 2)];

            for (int j = 1; j < mas.GetLength(0); j += 2)
            {
                for (int i = 0; i < mas.GetLength(1); i++)
                {
                    result[j / 2] += mas[j, i];
                }
            }
            return result;
        }
    }

    public static class VisualArray
    {
        public static DataTable ToDataTable<T>(this T[] arr)
        {
            var res = new DataTable();
            for (int i = 0; i < arr.Length; i++)
            {
                res.Columns.Add("col" + (i + 1), typeof(T));
            }
            var row = res.NewRow();
            for (int i = 0; i < arr.Length; i++)
            {
                row[i] = arr[i];
            }
            res.Rows.Add(row);
            return res;
        }
        public static DataTable ToDataTable<T>(this T[,] matrix)
        {
            var res = new DataTable();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                res.Columns.Add("col" + (i + 1), typeof(T));
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var row = res.NewRow();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = matrix[i, j];
                }

                res.Rows.Add(row);
            }

            return res;
        }


    }

    public class Triad
    {
        protected int _value1, _value2, _value3;

        public int Value1 { get { return _value1; } set { _value1 = value; } }

        public int Value2 { get { return _value2; } set { _value2 = value; } }

        public int Value3 { get { return _value3; } set { _value3 = value; } }

        public Triad()
        {
            Random rnd = new();
            _value1 = rnd.Next(0, 10);
            _value2 = rnd.Next(0, 10);
            _value3 = rnd.Next(0, 10);
        }

        public Triad(int minValue, int maxValue)
        {
            Random rnd = new();
            _value1 = rnd.Next(minValue, maxValue);
            _value2 = rnd.Next(minValue, maxValue);
            _value3 = rnd.Next(minValue, maxValue);
        }

        public Triad(int v1, int v2, int v3)
        {
            _value1 = v1; _value2 = v2; _value3 = v3;
        }

        /// <summary>
        /// Вычисляет сумму чисел
        /// </summary>
        /// <returns>Сумма чисел</returns>
        public int Summ()
        {
            return _value1 + _value2 + _value3;
        }

        /// <summary>
        /// Вычисляет произведение чисел
        /// </summary>
        /// <returns>Произведение чисел</returns>
        public int Multiply()
        {
            return _value1 * _value2 * _value3;
        }

        /// <summary>
        /// Ищет максимальное значение из 3х
        /// </summary>
        /// <returns>Максимальное значение</returns>
        public int GetMax()
        {
            int max = 0;

            if (_value1 >= _value2 && _value1 >= _value3) max = _value1;
            else if (_value2 >= _value1 && _value2 >= _value3) max = _value2;
            else if (_value3 >= _value1 && _value3 >= _value2) max = _value3;

            return max;
        }

        /// <summary>
        /// Ищет минимальное значение из 3х
        /// </summary>
        /// <returns></returns>
        public int GetMin()
        {
            int min = 0;

            if (_value1 <= _value2 && _value1 <= _value3) min = _value1;
            else if (_value2 <= _value1 && _value2 <= _value3) min = _value2;
            else if (_value3 <= _value1 && _value3 <= _value2) min = _value3;

            return min;
        }

        /// <summary>
        /// Записывает все числа в массив
        /// </summary>
        /// <returns>Массив</returns>
        public int[] GetArray()
        {
            int[] mas = new int[3];

            mas[0] = _value1;
            mas[1] = _value2;
            mas[2] = _value3;

            return mas;
        }

        /// <summary>
        /// Определяет, если две тройки чисел полностью не равны
        /// </summary>
        /// <param name="tr1">Первая тройка чисел</param>
        /// <param name="tr2">Вторая тройка чисел</param>
        /// <returns>Результат сравнения True/False</returns>
        public static bool operator !=(Triad tr1, Triad tr2) => (tr1._value1 != tr2._value1 && tr1._value2 != tr2._value2 && tr1._value3 != tr2._value3);

        /// <summary>
        /// Определяет, если две тройки чисел полностью равны
        /// </summary>
        /// <param name="tr1">Первая тройка чисел</param>
        /// <param name="tr2">Вторая тройка чисел</param>
        /// <returns>Результат сравнения True/False</returns>
        public static bool operator ==(Triad tr1, Triad tr2) => (tr1._value1 == tr2._value1 && tr1._value2 == tr2._value2 && tr1._value3 == tr2._value3);

        /// <summary>
        /// Определяет, если все числа из тройки равны
        /// </summary>
        /// <param name="tr">Тройка чисел</param>
        /// <returns>Результат сравнения True/False</returns>
        public static bool operator true(Triad tr) => (tr._value1 == tr._value2 && tr._value2 == tr._value3);

        /// <summary>
        /// Определяет, если все числа из тройки не равны
        /// </summary>
        /// <param name="tr">Тройка чисел</param>
        /// <returns>Результат сравнения True/False</returns>
        public static bool operator false(Triad tr) => (tr._value1 != tr._value2 && tr._value1 != tr._value3 && tr._value2 != tr._value3);
    }

    public class Triangle : Triad
    {
        public Triangle(int v1, int v2, int v3) : base(v1, v2, v3)
        {
        }

        public void GetAngles(out double angle1, out double angle2, out double angle3)
        {
            angle1 = Math.Acos((Math.Pow(_value1, 2) + Math.Pow(_value2, 2) - Math.Pow(_value3, 2)) / (2 * _value1 * _value2));
            angle2 = Math.Acos((Math.Pow(_value1, 2) + Math.Pow(_value2, 2) - Math.Pow(_value3, 2)) / (2 * _value2 * _value3));
            angle3 = Math.Acos((Math.Pow(_value1, 2) + Math.Pow(_value2, 2) - Math.Pow(_value3, 2)) / (2 * _value3 * _value1));

            angle1 = Math.Round((angle1 * 180 / Math.PI), 2);
            angle2 = Math.Round((angle2 * 180 / Math.PI), 2);
            angle3 = Math.Round((angle3 * 180 / Math.PI), 2);
        }

        public double GetArea()
        {
            double P = GetPerimeter();
            double p = P / 2;

            return Math.Round(Math.Sqrt(p * (p - _value1) * (p - _value2) * (p - _value3)), 2);
        }

        public int GetPerimeter()
        {
            return _value1 + _value2 + _value3;
        }

        public bool IsTriangleExist()
        {
            if (!(_value1 + _value2 >= _value3))
            {
                _value1 = _value2 = _value3 = 0;
                return false;
            }
            else return true;
        }

    }

    public class Student : IHuman, IMark, IComparable
    {
        string _firstName, _secondName, _gender, _group;
        int _age;

        public string FirstName { get { return _firstName; } }
        public string SecondName { get { return _secondName; } }
        public int Age { get { return _age; } }
        public string Gender { get { return _gender; } }
        public string Group { get { return _group; } }

        public Student(string firstName, string secondName, int age, string gender, string group)
        {
            _firstName = firstName; _secondName = secondName;
            _age = age; _gender = gender; _group = group;
        }

        public string GetInfo()
        {
            string info = "Имя: " + _firstName + "\nФамилия: " + _secondName + "\nВозраст: " + Age
                + "\nПол: " + _gender + "\nГруппа: " + _group;
            return info;
        }

        public int CompareTo(object obj)
        {
            Student temp = (Student)obj;

            if (this._secondName.Length == temp._secondName.Length) return 0;
            else if (this._secondName.Length > temp._secondName.Length) return 1;
            else return -1;
        }
    }
}

