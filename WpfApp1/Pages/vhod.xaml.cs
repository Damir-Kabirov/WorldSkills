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
    /// Логика взаимодействия для vhod.xaml
    /// </summary>
    public partial class vhod : Page
    {
        public vhod()
        {
            InitializeComponent();
          
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new glav());
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var email = LoginBox.Text;
            var pass = PassBox.Password;

            var BD = new marathonEntities();

            var runner = BD.Runner.Where(r => r.Email == email && r.User.Password == pass).FirstOrDefault();
            if (runner != null)
            {
                this.NavigationService.Navigate(new Dannye(runner));
            } else
            {
                MessageBox.Show("Не найдено");
             }
        }
    }
}
