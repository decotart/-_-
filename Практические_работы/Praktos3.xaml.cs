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
using LibMasMain;
using Lib_6_version_2._0_;
using System.Data;
using System.IO;
using Microsoft.Win32;

namespace Практические_работы
{
    /// <summary>
    /// Логика взаимодействия для Praktos3.xaml
    /// </summary>
    public partial class Praktos3 : Window
    {
        int[,] mas = new int[6, 6];
        public Praktos3()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, RoutedEventArgs e)
        {
            ArrayMod.FillRandom(mas);
            mainDataTable.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ArrayMod.Clear(mas);
            mainDataTable.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }

        private void btnProgrammInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ФИО разработчика, номер работы и формулировку задания");
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dataGridCellEditing(object sender, DataGridCellEditEndingEventArgs e)
        {
            int inedx0 = e.Column.DisplayIndex;
            int index1 = e.Row.GetIndex();

            bool f = int.TryParse(((TextBox)e.EditingElement).Text, out int value);
            if (f)
            {
                mas[inedx0, index1] = value;
            }
            else
            {
                MessageBox.Show("неверное значение");
            }
        }

        private void btnGetResult_Click(object sender, RoutedEventArgs e)
        {
            int[] result = Work3.Function3(mas);
            dataGridResult.ItemsSource = VisualArray.ToDataTable(result).DefaultView;

        }

        private void mi_SaveClick(object sender, RoutedEventArgs e)
        {
            ArrayMod.Save(mas);
        }

        private void mi_OpenClick(object sender, RoutedEventArgs e)
        {
            mas = ArrayMod.Open();
            mainDataTable.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;

            btnGetResult_Click(sender, e);
        }
    }
}
