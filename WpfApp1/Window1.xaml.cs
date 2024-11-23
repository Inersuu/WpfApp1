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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int balls = 0;
            if (Radiobtn4.IsChecked == true)
            {
                balls++;
            }
            if (Radiobtn6.IsChecked == true)
            {
                balls++;
            }
            if (Radiobtn10.IsChecked == true)
            {
                balls++;
            }
            if (Radiobtn13.IsChecked == true)
            {
                balls++;
            }
            if (Radiobtn17.IsChecked == true)
            {
                balls++;
            }
            if (balls == 0)
            {
                MessageBox.Show($"Иди выключи комп и возьми читай книгу по истории: {balls}");
            }
            else if (balls == 1)
            {
                MessageBox.Show($"Нешаришь: {balls}");
            }
            else if (balls == 2)
            {
                MessageBox.Show($"Не слон: {balls}");
            }
            else if (balls == 3)
            {
                MessageBox.Show($"Неплох: {balls}");
            }
            else
            {
                MessageBox.Show($"Наш слон: {balls}");
            }
        }
    }
}
