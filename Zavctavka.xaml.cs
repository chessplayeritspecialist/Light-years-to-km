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
using System.Windows.Shapes;


namespace Light_years_to_km
{
    /// <summary>
    /// Логика взаимодействия для Zavctavka.xaml
    /// </summary>
    public partial class Zavctavka : Window
    {
        public Zavctavka()
        {

            InitializeComponent();
            
        }

        private void start(object sender, EventArgs e)
        {
            video.Play();

        }

        private void video_MediaEnded(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            Close();

        }
    }
}
