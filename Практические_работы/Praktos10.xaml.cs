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
    /// Логика взаимодействия для Praktos10.xaml
    /// </summary>
    public partial class Praktos10 : Window
    {
        public Praktos10()
        {
            InitializeComponent();
        }
        
        List<int> main = new List<int>();
        List<int> result = new List<int>();

        private static int GetIndexOfMaxElement(List<int> list, out int maxValue)
        {
            maxValue = list[0];
            int index = 0;
            
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > maxValue)
                {
                    maxValue = list[i];
                    index = i;
                }
            }
            
            return index;
        }

        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lbResult.Items.Clear();

                int index = GetIndexOfMaxElement(main, out int maxElement);

                result = main;

                int zeroElement = main[0];

                result[index] = zeroElement;
                result[0] = maxElement;

                foreach (int i in result)
                {
                    lbResult.Items.Add(i);
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так");
            }
        }

        private void btnFill_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                const int MaxRandomValue = 10,
                    MinRandomValue = -10;

                Random rnd = new();

                int count = Convert.ToInt32(tbRandomValuesCount.Text);

                for (int i = 0; i < count; i++)
                {
                    int value = rnd.Next(MinRandomValue, MaxRandomValue);
                    lbValues.Items.Add(value);
                    main.Add(value);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(tbValue.Text);
                lbValues.Items.Add(value);
                main.Add(value);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lbResult.Items.Clear();
            lbValues.Items.Clear();

            main.Clear();
            result.Clear();

            tbRandomValuesCount.Clear();
            tbValue.Clear();
        }

        private void lbValues_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lbValues.SelectedIndex != -1)
            {
                main.RemoveAt(lbValues.SelectedIndex);
                lbValues.Items.RemoveAt(lbValues.SelectedIndex);
            }
        }
    }
}
