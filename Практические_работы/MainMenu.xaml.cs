using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Практические_работы
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        int numb;
        Praktos3 pr3;
        praktos5 pr5;
        Praktos6 pr6;
        Praktos7 pr7;
        Praktos8 pr8;
        Praktos9 pr9;
        Praktos10 pr10;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void prInfo_Click(object sender, RoutedEventArgs e)
        {
            string info = mainTextBlock.Text;

            bool f = int.TryParse(tbNumb.Text, out numb);
            if (f)
            {
                switch (numb)
                {
                    case 3:
                        info = " Дана матрица размера M × N. Для каждого столбца матрицы с четным номером (2, \r\n4, …)" +
                            " найти сумму его элементов. Условный оператор не использовать. ";
                        break;

                    case 4:
                        info = "1. Зарегистрироваться в системе контроля версий GitHub.\r\n" +
                            "2. Выгрузить в репозиторий GitHub практические работы №1, №2 и №3.\r\n" +
                            "3. Внести любое изменение в практическую работу №1 и выгрузить изменения в \r\nлокальный и удаленный репозиторий.\r\n" +
                            "4. Загрузить из удаленного репозитория GitHub работы на локальный компьютер.\r\n5. Отчитаться о проделанной работе";
                        break;

                    case 5:
                        info = "Создать класс Triad (тройка положительных чисел). Создать необходимые методы " +
                            "\r\nи свойства. Определить метод вычисления суммы чисел. Создать перегруженные " +
                            "\r\nметоды SetParams, для установки параметров объекта.";
                        break;

                    case 6:
                        info = "Использовать класс Triad (тройка положительных чисел). Разработать операции\r\n" +
                            "определения равенства/неравенства чисел true/false. Разработать операции \r\n" +
                            "проверки полного равенства/неравенства чисел в триадах (a1,b1,c1) == (a2,b2,c2). ";
                        break;

                    case 7:
                        info = "Использовать класс Triad (тройка положительных чисел). Определить производный \r\n" +
                            "класс Triangle с полями-сторонами. Определить методы вычисления углов и \r\n" +
                            "площади треугольника.";
                        break;

                    case 8:
                        info = "Создать интерфейсы – человек и печать (для формирования информации об \r\n" +
                            "объекте). Создать класс – студент. Класс должен включать конструкторы функцию\r\n" +
                            "для формирования строки информации о студенте. Сравнение производить по \r\n" +
                            "фамилии";
                        break;

                    case 9:
                        info = "Заполнить таблицу на 5 предметов с полями: предмет, ФИО лектора, номер \r\n" +
                            "аудитории, кол-во часов в семестре. Вывести результат на экран. Вывести список \r\n" +
                            "лекторов работающих в заданной аудитории.";
                        break;

                    case 10:
                        info = "В массиве чисел найти наибольший элемент и поменять его местами с первым \nэлементом.";
                        break;

                    default:
                        info = "Практической работы с таким номером нет в программе";
                        break;


                }
                mainTextBlock.Text = info;
            }
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            bool f = int.TryParse(tbNumb.Text, out numb);
            if (f)
            {
                switch (numb)
                {
                    case 3:
                        pr3 = new();
                        pr3.Show();
                        break;

                    case 4:
                        MessageBox.Show("Практическая работа не имеет своего окна");
                        break;

                    case 5:
                        pr5 = new();
                        pr5.Show();
                        break;

                    case 6:
                        pr6 = new();
                        pr6.Show();
                        break;

                    case 7:
                        pr7 = new();
                        pr7.Show();
                        break;

                    case 8:
                        pr8 = new();
                        pr8.Show();
                        break;

                    case 9:
                        pr9 = new();
                        pr9.Show();
                        break;

                    case 10:
                        pr10 = new();
                        pr10.Show();
                        break;

                    default:
                        MessageBox.Show("Практической работы с таким номером нет в программе");
                        break;
                }
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
