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
    /// Логика взаимодействия для sob.xaml
    /// </summary>
    public partial class sob : Page
    {
        public sob()
        {
            InitializeComponent();
            UserDG.ItemsSource = Core.BD.User.ToList();

        }

        private void DeliteButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedUser = UserDG.SelectedItem as User;
            Core.BD.User.Remove(selectedUser);
            Core.BD.SaveChanges();
            MessageBox.Show("Запись удалена");

        }



    

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AbdateButtton_Click(object sender, RoutedEventArgs e)
        {
            var selectedUser = UserDG.SelectedItem as User;
            var editW = new Page1(selectedUser);
            this.NavigationService.Navigate(editW);
        }
    }
}
