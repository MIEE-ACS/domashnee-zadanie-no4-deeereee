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
    /// Логика взаимодействия для Matrix.xaml
    /// </summary>
    /// 



    public partial class Matrix : Window
    {
        static Random rand = new Random();
        static int readInt()
        {
            return rand.Next(-20, 20);
        }


        public Matrix()
        {
            InitializeComponent();
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
           
            n = int.Parse(tb_str.Text);
            m = int.Parse(tb_stolb.Text);

            if (n <= 0 && n <= 0)
            {
                MessageBox.Show("Значения должны быть больше ноля.",
                     "Ошибка!",
                 MessageBoxButton.OK,
                MessageBoxImage.Error);
            }
            else
            {




                int[,] s = new int[n, m];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        s[i, j] = readInt();

                    }

                }

                List<int[]> s2 = new List<int[]>();
                List<int> s6 = new List<int>();
                int[] s5 = new int[n];
                for (int i = 0; i < n; i++)
                {
                    int x = 0;
                    int[] s3 = new int[m];
                    for (int j = 0; j < m; j++)
                    {
                        s3[j] = s[i, j];
                        s5[i] += s[i, j];
                        if (s[i, j] == 0)
                            x = 1;
                    }
                    s2.Add(s3);
                    if (x == 0)
                        s5[i] = 0;
                    s6.Add(s5[i]);
                }

                //s2.Add(s5);
                dgrid.ItemsSource = s2;

                for (int j = 0; j < m; j++)
                    dgrid.Columns.Add(new DataGridTextColumn { Binding = new Binding(String.Format("[{0}]", j)) });



                dgrid2.ItemsSource = s6;
                //for (int j = 0; j < m; j++)
                dgrid2.Columns.Add(new DataGridTextColumn { Binding = new Binding() });

                int flag_str = 0;
                int flag_stolb = 0;

                for (int i = 0; i < n; i++)
                {
                    flag_str = 0;
                    flag_stolb = 0;

                    for (int j = 0; j < m; j++)
                    {

                        for (int x = 0; x < m; x++)
                        {
                            if (s[i, x] < s[i, j])
                                flag_str = 1;
                        }

                        if (flag_str == 0)
                        {
                            for (int x = 0; x < n; x++)
                            {
                                if (s[x, j] > s[i, j])
                                    flag_stolb = 1;
                            }
                        }

                        if (flag_str == 0 && flag_stolb == 0)
                            tb2.Text += "[" + i + "," + j + "]" + ";";
                    }

                }
            }
        }


   
    }
}
