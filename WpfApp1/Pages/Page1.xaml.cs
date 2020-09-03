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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {

        private User correntPos;

        public Page1(User pos)
        {
            InitializeComponent();
            correntPos = pos;
            tb1.Text = pos.FirstName;
            tb2.Text = pos.LastName;

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            correntPos.FirstName = tb1.Text;
            correntPos.LastName = tb2.Text;
            Core.BD.SaveChanges();
            MessageBox.Show("Изменено");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new glav());
        }
    }
}
