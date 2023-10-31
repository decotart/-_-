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
    /// Логика взаимодействия для Praktos7.xaml
    /// </summary>
    public partial class Praktos7 : Window
    {
        Triangle triangle = new(0, 0, 0);
        bool isTriangleGotValues;

        public Praktos7()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            GetValues(tbValue1.Text, tbValue2.Text, tbValue3.Text, triangle);

            if (isTriangleGotValues)
            {
                if (triangle.IsTriangleExist() == true)
                {
                    double ang1, ang2, ang3;

                    triangle.GetAngles(out ang1, out ang2, out ang3);

                    tbAngle1.Text = ang1.ToString();
                    tbAngle2.Text = ang2.ToString();
                    tbAngle3.Text = ang3.ToString();

                    double area = triangle.GetArea();
                    tbArea.Text = area.ToString();

                    int perimeter = triangle.GetPerimeter();
                    tbPerimeter.Text = perimeter.ToString();
                }
                else MessageBox.Show("Такого треугольника не существует");
            }
        }

        private void GetValues(string v1, string v2, string v3, Triangle triangle)
        {
            bool f1, f2, f3;

            f1 = int.TryParse(v1, out int value1);
            f2 = int.TryParse(v2, out int value2);
            f3 = int.TryParse(v3, out int value3);

            if (f1 && f2 && f3)
            {
                isTriangleGotValues = true;
                triangle.Value1 = value1;
                triangle.Value2 = value2;
                triangle.Value3 = value3;
            }
            else isTriangleGotValues = false;
        }
    }
}
