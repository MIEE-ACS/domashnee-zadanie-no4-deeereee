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

namespace Dz_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Button_Click_Array(object sender, RoutedEventArgs e)
        {
            Array array = new Array();
            array.Show();
            Hide();

        }

        private void Button_Click_Matrix(object sender, RoutedEventArgs e)
        {
            Matrix matrix = new Matrix();
            matrix.Show();
            Hide();
        }

       
    }
}
