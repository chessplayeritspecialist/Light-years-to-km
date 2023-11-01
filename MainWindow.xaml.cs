using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Light_years_to_km
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

        private void info_click(object sender, MouseButtonEventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void Nav(object sender, MouseEventArgs e)
        {
            clear.Height = 98;
            clear.Width = 97;
        }

        private void Dav(object sender, MouseEventArgs e)
        {
            clear.Height = 87;
            clear.Width = 86;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Algorithm_light_years_to_km algorithm_Light_Years_To_Km = new Algorithm_light_years_to_km();
                text_b.Text = Convert.ToString(algorithm_Light_Years_To_Km.Summ(Convert.ToDouble(text_a.Text)));
            }
            catch (System.FormatException)
            {

                MessageBox.Show("Вы должны ввести число", "Ошибка");
                text_a.Text = "";
            }

        }

        private void Clear(object sender, MouseButtonEventArgs e)
        {
            text_a.Text = "0";
            text_b.Text = "0";
        }
    }
}
