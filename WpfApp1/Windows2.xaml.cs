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
    /// Логика взаимодействия для Windows2.xaml
    /// </summary>
    public partial class Windows2 : Window
    {
        Test test = new Test();
        public Windows2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow windows = new MainWindow();
            windows.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            tbox.Text = "Это кнопка";
            Ibg.Source = BitmapFrame.Create(new Uri(@"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\KorbachevIV\Downloads\2024-10-30_14-29-57.png"));
            
        }
    }
}
