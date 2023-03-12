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
    /// Логика взаимодействия для AP5.xaml
    /// </summary>
    public partial class AP5 : Page
    {
        public AP5()
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
                double k1 = 3.1;
                double k2 = 0.78;
                double k3 = 1.1;
                double m1 = 5.15;
                double m2 = -2.4;
                double m3 = 4.36;
                double n1 = -1.15;
                double n2 = 4.36;
                double n3 = 0.41;
                if (Math.Pow(x,2) > m1 + n1)
                {
                    MessageBox.Show($"y = {Math.Log10(Math.Abs(m1 * x + n1))}");
                }
                if (Math.Pow(x, 2) > m2 + n2)
                {
                    MessageBox.Show($"y = {Math.Exp(Math.Cos(Math.Abs(m2 * x - n2)))}");
                }
                if (Math.Pow(x, 2) > m3 + n3)
                {
                    MessageBox.Show($"y = {Math.Pow(Math.Sqrt(Math.Pow(k3,2) + Math.Pow(Math.Cos(x),2)),3)}");
                }

            }
            catch
            {
                MessageBox.Show($"ВЫХОДИ ОТСЮДА, А ТО ЗАРЕЖУ!! ААААААААААААААААА!!! *агрессивно достает нож*");
            }
        }
    }
}
