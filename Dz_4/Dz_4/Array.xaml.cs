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

namespace Dz_4
{
    /// <summary>
    /// Логика взаимодействия для Array.xaml
    /// </summary>
    public partial class Array : Window
    {
        static Random rand = new Random();
        static int readInt()
        {
            return rand.Next(-20, 20);
        }






        public Array()
        {
            InitializeComponent();
          
        }

        private void Button_Click_MainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            Hide();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n, m;

            n = int.Parse(tb1.Text);
            tb_mass.Text = "";
            tb_mass2.Text = "";
            if (n <= 0 && n <= 0)
            {
                MessageBox.Show("Значения должны быть больше ноля.",
                     "Ошибка!",
                 MessageBoxButton.OK,
                MessageBoxImage.Error);
            }
            else
            {




                int[] s = new int[n];

                for (int i = 0; i < n; i++)
                {                    
                  s[i] = readInt();
                    tb_mass.Text += s[i] + ", ";
                }

                int pr = 1;
                for (int i = 0; i < n; i++)
                {
                    if (s[i] > 0)
                        pr = pr * s[i];
                }
                tb_pr.Text = pr.ToString();

                
                int imin = 0;
                for (int i = 1; i < n; i++)
                {
                    if (s[i] < s[imin])
                        imin = i;
                }

                int sum = 0;
                for (int i = 0; i < imin; i++)
                {
                    sum += s[i];
                }

                tb_sum.Text = sum.ToString();

                int x;
                for (int i = 1; i < n-1; i=i+2)
                {
                    for (int j = i+2; j < n; j=j+2)
                    {
                        if (s[i] > s[j])
                        {
                            x = s[i];
                            s[i] = s[j];
                            s[j] = x;
                        }
                    }
                }

                for (int i = 0; i < n - 1; i = i + 2)
                {
                    for (int j = i + 2; j < n; j = j + 2)
                    {
                        if (s[i] > s[j])
                        {
                            x = s[i];
                            s[i] = s[j];
                            s[j] = x;
                        }
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    
                    tb_mass2.Text += s[i] + ", ";
                }

            }
        }
    }
}
