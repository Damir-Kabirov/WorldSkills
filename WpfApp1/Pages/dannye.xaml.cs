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
    /// Логика взаимодействия для Dannye.xaml
    /// </summary>
    public partial class Dannye : Page
    {
        public Dannye(Runner r)
        {
            InitializeComponent();
            CurrentRunner = r;
            DataContext = this;

        }
        public Runner CurrentRunner{ get; set; }
    }
}
