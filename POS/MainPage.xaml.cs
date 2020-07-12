using POS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace POS_app
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public void Place_ord(object sender, RoutedEventArgs e)
        {
            CustomerPage customerpage = new CustomerPage();
            this.NavigationService.Navigate(customerpage);
        }
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
