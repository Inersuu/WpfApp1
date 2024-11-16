using System;
using Microsoft.Win32;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAC_Click(object sender, RoutedEventArgs e)
        {
            //txtDisplay.Text = "";
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            //string a = txtDisplay.Text;
            //txtDisplay.Text = a + "1";
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
           //string a = txtDisplay.Text;
           //txtDisplay.Text = a + " + ";
        }

        private void BtnRovno_Click(object sender, RoutedEventArgs e)
        {
            //int a = Convert.ToInt32(txtDisplay.Text);
            //txtDisplay.Text = Convert.ToString(a);
        }










        /*private void Button_Click(object sender, RoutedEventArgs e)
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
            OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "Image Files| *.jpg; *.jpeg; *.png; *.gif; *.bmp; *.webm" };
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage bitmapImage = new BitmapImage(new Uri(openFileDialog.FileName));
                DisplayImage.Source = bitmapImage;
            }
        }*/
    }
}
