using Lib_6_version_2._0_;
using Lib6;
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
    /// Логика взаимодействия для Praktos9.xaml
    /// </summary>
    public partial class Praktos9 : Window
    {
        List<Lessons> lessons = new List<Lessons>();
        Lessons l1 = new(),
            l2 = new(),
            l3 = new(),
            l4 = new(),
            l5 = new();

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int classNum = Convert.ToInt32(tbClassNumber.Text);
                List<string> result = Lessons.GetLectorsInClass(lessons, classNum);

                tbResult.Clear();

                foreach (string i in result)
                {
                    tbResult.Text = tbResult.Text + i + "\n";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод");
                tbClassNumber.Clear();
            }
            catch (LectorsNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Praktos9()
        {
            InitializeComponent();
        }

        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            lessons.Add(l1);
            lessons.Add(l2);
            lessons.Add(l3);
            lessons.Add(l4);
            lessons.Add(l5);

            dataGrid.ItemsSource = lessons;
        }

        private void dataGrid_CellEditing(object sender, DataGridCellEditEndingEventArgs e)
        {
            int columnIndex = e.Column.DisplayIndex,
                rowIndex = e.Row.GetIndex();

            try
            {
                Lessons temp = lessons[rowIndex];

                switch (columnIndex)
                {
                    case 0:
                        temp.Lesson = ((TextBox)e.EditingElement).Text;
                        break;
                    case 1:
                        temp.Lector = ((TextBox)e.EditingElement).Text;
                        break;
                    case 2:
                        temp.ClassNumber = Convert.ToInt32(((TextBox)e.EditingElement).Text);
                        break;
                    case 3:
                        temp.Hours = Convert.ToInt32(((TextBox)e.EditingElement).Text);
                        break;
                }
                lessons[rowIndex] = temp;
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод");
                ((TextBox)e.EditingElement).Text = "0";
            }
        }
    }
}
