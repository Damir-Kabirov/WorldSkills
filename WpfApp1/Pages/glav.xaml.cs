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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для glav.xaml
    /// </summary>
    public partial class glav : Page
    {
        public glav()
        {
            InitializeComponent();
        }

        private void Begun_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new avt());
        }

        private void Log_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new vhod());
        }

        private void Cponsor_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new sponsor());
        }

        private void Sob_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new sob());
        }
    }
}
