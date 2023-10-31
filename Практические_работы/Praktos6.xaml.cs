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
using Lib_6_version_2._0_;

namespace Практические_работы
{
    /// <summary>
    /// Логика взаимодействия для Praktos6.xaml
    /// </summary>
    public partial class Praktos6 : Window
    {
        Triad tr1;
        Triad tr2;
        bool isTr1DoesExist;
        bool isTr2DoesExist;


        public Praktos6()
        {
            InitializeComponent();
        }

        private void btn_IsFirstTrEqual(object sender, RoutedEventArgs e)
        {
            if (isTr1DoesExist)
            {
                if (tr1) tbResult.Text = "Верно";
                else tbResult.Text = "Ложь";
            }
        }

        private void btn_IsSecondTrEqual(object sender, RoutedEventArgs e)
        {
            if (isTr2DoesExist)
            {
                if (tr2) tbResult.Text = "Верно";
                else tbResult.Text = "Ложь";
            }
        }

        private void btn_IsBothTrsEqual(object sender, RoutedEventArgs e)
        {
            if (isTr1DoesExist && isTr2DoesExist)
            {
                if (tr1 == tr2) tbResult.Text = "Верно";
                else tbResult.Text = "Ложь";
            }
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            bool f1, f2, f3;

            f1 = int.TryParse(tbTr1Value1.Text, out int value1);
            f2 = int.TryParse(tbTr1Value2.Text, out int value2);
            f3 = int.TryParse(tbTr1Value3.Text, out int value3);

            if (f1 && f2 && f3)
            {
                tr1 = new(value1, value2, value3);
                isTr1DoesExist = true;
            }
            else isTr1DoesExist = false;
        }


        private void TextChanged2(object sender, TextChangedEventArgs e)
        {
            bool f4, f5, f6;

            f4 = int.TryParse(tbTr2Value1.Text, out int value4);
            f5 = int.TryParse(tbTr2Value2.Text, out int value5);
            f6 = int.TryParse(tbTr2Value3.Text, out int value6);

            if (f4 && f5 && f6)
            {
                tr2 = new(value4, value5, value6);
                isTr2DoesExist = true;
            }
            else isTr2DoesExist = false;
        }
    }
}
