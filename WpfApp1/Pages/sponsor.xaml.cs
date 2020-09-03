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
    /// Логика взаимодействия для sponsor.xaml
    /// </summary>
    public partial class sponsor : Page
    {
        public sponsor()
        {
            InitializeComponent();
            List <User> users = Core.BD.User.ToList();
            roleDataGrid.ItemsSource = users;
            RoleNameComboBox.ItemsSource = Core.BD.Role.ToList();


        }

        private void FiltButton_Click(object sender, RoutedEventArgs e)
        {
            var item = RoleNameComboBox.SelectedItem;
            if (item== null)
            {
                MessageBox.Show("Роль не выбрана");
                return;
            }
            var selectedRole = item as Role;

            var usersFromOnRole = Core.BD.User.Where(r => r.RoleId == selectedRole.RoleId).ToList();
            roleDataGrid.ItemsSource = usersFromOnRole;
        }

        private void VceButton_Click(object sender, RoutedEventArgs e)
        {
            List<User> selectVse= Core.BD.User.ToList();
            roleDataGrid.ItemsSource = selectVse; 

        }
    }
}
