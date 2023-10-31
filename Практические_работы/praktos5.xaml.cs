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
using Lib_6_version_2;
using Lib_6_version_2._0_;

namespace Практические_работы
{
    /// <summary>
    /// Логика взаимодействия для praktos5.xaml
    /// </summary>
    public partial class praktos5 : Window
    {
        Triad triad;

        public praktos5()
        {
            InitializeComponent();
        }

        private void btn_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("о программе"); ;
        }

        private void btn_ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_GetResultsClick(object sender, RoutedEventArgs e)
        {
            bool f1, f2, f3;

            f1 = int.TryParse(tbValue1.Text, out int value1);
            f2 = int.TryParse(tbValue2.Text, out int value2);
            f3 = int.TryParse(tbValue3.Text, out int value3);

            if (f1 && f2 && f3)
            {
                triad = new Triad(value1, value2, value3);

                tbSumm.Text = triad.Summ().ToString();
                tbMax.Text = triad.GetMax().ToString();
                tbMin.Text = triad.GetMin().ToString();
            }
            else MessageBox.Show("Введите значения правильно");
        }
    }
}
