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
    /// Логика взаимодействия для AP2.xaml
    /// </summary>
    public partial class AP2 : Page
    {
        public AP2()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TbF2.Text);
                double a1 = 4.2;
                double a2 = -0.35;
                double a3 = 2.8;
                double b1 = 5.3;
                double b2 = 1.8;
                double b3 = -0.6;
                double c1 = 1.5;
                double c2 = -1.8;
                double c3 = 2.0;
                if (Math.Exp(a1+b1) > Math.Exp(x))
                {
                    MessageBox.Show($"y = {Math.Sin(Math.Exp(a1 + b1) + Math.Pow(x,2))}");
                }
                if (Math.Exp(a2 + b2) == Math.Exp(x))
                {
                    MessageBox.Show($"y = {Math.Atan(a2 * b2 * c3) + Math.Pow(Math.Sqrt(x), 3)}");
                }
                if (Math.Exp(a1 + b1) < Math.Exp(x))
                {
                    MessageBox.Show($"y = {Math.Cos(Math.Sqrt(Math.Abs(x + a3 * b3 * c3)))}");
                }

            }
            catch
            {
                MessageBox.Show($"ВЫХОДИ ОТСЮДА, А ТО ЗАРЕЖУ!! ААААААААААААААААА!!! *агрессивно достает нож*");
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            TestCoreFR.MyCore?.Navigate(new MainPage());
        }
    }
}
