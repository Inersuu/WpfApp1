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
        private double _currentValue = 0;
        private double _storedValue = 0;
        private char _operation = ' ';
        public MainWindow()
        {
            InitializeComponent();
        }
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Content.ToString();
            if (txtDisplay.Text == "0" && number != ".")
            {
                txtDisplay.Text = number;
            }
            else
            {
                txtDisplay.Text += number;
            }
        }
        private void OperationButton_Click(Object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            _operation = button.Content.ToString()[0];
            _storedValue = double.Parse(txtDisplay.Text);
            txtDisplay.Text = "0";
        }
        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            _currentValue = double.Parse(txtDisplay.Text);
            switch( _operation )
            {
                case '+':
                    _currentValue = _storedValue + _currentValue;
                    break;

                case '-':
                    _currentValue = _storedValue - _currentValue;
                    break;
                case '*':
                    _currentValue = _storedValue * _currentValue;
                    break;
                case '/':
                    if(_currentValue != 0)
                    {
                        _currentValue = _storedValue / _currentValue;
                    }
                    else
                    {
                        MessageBox.Show("На ноль делить нельзя");
                    }
                    break;
            }
            txtDisplay.Text = _currentValue.ToString();
            _operation = '\0';
        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "0";
            _currentValue = 0;
            _storedValue = 0;
            _operation = '\0';
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Close();
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
