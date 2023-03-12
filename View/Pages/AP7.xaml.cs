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
using TestProject.Core;

namespace TestProject.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AP7.xaml
    /// </summary>
    public partial class AP7 : Page
    {
        public AP7()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            TestCoreFR.MyCore?.Navigate(new MainPage());
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TbF2.Text);
                double a1 = 0.1;
                double a2 = 10;
                double a3 = 100;
                double b1 = 9.8;
                double b2 = 10.05;
                double b3 = 3.03;
                double z1 = 11.12;
                double z2 = 6.2;
                double z3 = 7.12;
                if (Math.Log10(a1) < x)
                {
                    MessageBox.Show($"y = {Math.Pow(Math.Sqrt(Math.Pow(b1,2) + Math.Sqrt(Math.Abs(x + z1))),3)}");
                }
                if (Math.Log10(a2) == x)
                {
                    MessageBox.Show($"y = {Math.Cos(x - b2 - z2)}");
                }
                if (Math.Log10(a3) > x)
                {
                    MessageBox.Show($"y = {Math.Sin(x + a3 - b3)}");
                }

            }
            catch
            {
                MessageBox.Show($"ВЫХОДИ ОТСЮДА, А ТО ЗАРЕЖУ!! ААААААААААААААААА!!! *агрессивно достает нож*");
            }
        }
    }
}
