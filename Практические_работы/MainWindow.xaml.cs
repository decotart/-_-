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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Практические_работы
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainMenu menuWindow = new();
        public MainWindow()
        {
            InitializeComponent();
            menuWindow.Show();
            this.Close();
        }

        public void btn_Work3(object sender, RoutedEventArgs e)
        {
            Praktos3 praktos3 = new Praktos3();
            praktos3.Show();
        }

        private void btn_Work4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("(на гитхабе)");
        }

        private void btn_Work5(object sender, RoutedEventArgs e)
        {
            praktos5 pr = new();
            pr.Show();
        }
    }
}
