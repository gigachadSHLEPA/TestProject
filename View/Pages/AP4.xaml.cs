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
    /// Логика взаимодействия для AP4.xaml
    /// </summary>
    public partial class AP4 : Page
    {
        public AP4()
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
                double a1 = 3.2;
                double a2 = 10.5;
                double a3 = 5.4;
                double b1 = -0.7;
                double b2 = -2.5;
                double b3 = 3;
                double c1 = 2.2;
                double c2 = 5.6;
                double c3 = 2.6;
                if (Math.Abs(1 - Math.Pow(x, 2)) == a1 + c1)
                {
                    MessageBox.Show($"y = {x * Math.Exp(a1) + Math.Exp(Math.Abs(b1 * c1))}");
                }
                if (Math.Abs(1 - Math.Pow(x, 2)) > a1 + c1)
                {
                    MessageBox.Show($"y = {Math.Pow(Math.Sin(a2 * x), 2) + Math.Cos(b2 * c2)}");
                }
                if (Math.Abs(1 - Math.Pow(x, 2)) < a1 + c1)
                {
                    MessageBox.Show($"y = {Math.Sqrt(a3 * Math.Pow(b3, 4) + Math.Pow(Math.Sqrt(c3 * Math.Pow(x, 3)), 5))}");
                }

            }
            catch
            {
                MessageBox.Show($"ВЫХОДИ ОТСЮДА, А ТО ЗАРЕЖУ!! ААААААААААААААААА!!! *агрессивно достает нож*");
            }
        }
    }
}
