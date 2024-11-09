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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string imgsource1 = @"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\KorbachevIV\Downloads\2131231.png";
        private string imgsource2 = @"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\KorbachevIV\Downloads\2024-10-30_14-29-57.png";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Windows2 windows2 = new Windows2();
            windows2.Show();
            this.Close();
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Приложение закрылось");
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            DisplayImage.Source = new BitmapImage(new Uri(imgsource1));
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            DisplayImage.Source = new BitmapImage(new Uri(imgsource2));
        }
    }
}
