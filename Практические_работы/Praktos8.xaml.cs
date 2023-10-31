using Lib_6_version_2._0_;
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
    /// Логика взаимодействия для Praktos8.xaml
    /// </summary>
    public partial class Praktos8 : Window
    {
        Student st1, st2;

        public Praktos8()
        {
            InitializeComponent();
        }

        private void tbStudent1_TextChanged(object sender, TextChangedEventArgs e)
        {
            st1 = null;

            string fName = tbSt1FName.Text,
                sName = tbSt1SName.Text,
                gender = tbSt1Gender.Text,
                group = tbSt1Group.Text;

            bool f = int.TryParse(tbSt1Age.Text, out int age);

            if (f)
            {
                st1 = new(fName, sName, age, gender, group);
            }

        }

        private void tbStudent2_TextChanged(object sender, TextChangedEventArgs e)
        {
            st2 = null;

            string fName = tbSt2FName.Text,
                sName = tbSt2SName.Text,
                gender = tbSt2Gender.Text,
                group = tbSt2Group.Text;

            bool f = int.TryParse(tbSt2Age.Text, out int age);

            if (f)
            {
                st2 = new(fName, sName, age, gender, group);
            }
        }

        private void btnCompare_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int resultOfCompare = st1.CompareTo(st2);

                if (resultOfCompare == 0) MessageBox.Show("Фамилии обоих студентов равной длины");
                if (resultOfCompare == 1) MessageBox.Show("Фамилия первого студента длинее");
                if (resultOfCompare == -1) MessageBox.Show("Фамилии второго студента длинее");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Данные студентов не были заполнены полностью, или заполнены не верно.");
            }
        }

        private void btnStudent1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string studentInfo = st1.GetInfo();
                MessageBox.Show(studentInfo);
            }
            catch
            {
                MessageBox.Show("Данные студента не были заполнены полностью, или заполнены не верно.");
            }
        }

        private void btnStudent2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string studentInfo = st2.GetInfo();
                MessageBox.Show(studentInfo);
            }
            catch
            {
                MessageBox.Show("Данные студента не были заполнены полностью, или заполнены не верно.");
            }
        }
    }
}
