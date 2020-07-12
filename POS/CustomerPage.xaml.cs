using POS;
using BAL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using POS_app;

namespace POS
{
    /// <summary>
    /// Interaction logic for CustomePage.xaml
    /// </summary>
    public partial class CustomerPage : Page
    {
        customer_List myobj = new customer_List();

        public void removeHandle(object sender, RoutedEventArgs e)
        {
            if (lbox.SelectedItem == null)
            {
                MessageBox.Show("No Customer Selected.");
            }
            else if(myobj.clist.Count != 0)
            {
                Customer temp = lbox.SelectedItem as Customer;
                int num = temp.ID_NUM;
                myobj.delete(num);
                lbox.ItemsSource = myobj.clist;
            }
            else
            {
                return;
            }
        }
        public void addHandle(object sender, RoutedEventArgs e)
        {
            CustomerEnteryWindow enterypage = new CustomerEnteryWindow(this.myobj, this.lbox);
            enterypage.Show();
            lbox.ItemsSource = this.myobj.clist;
        }
        public void orderHandle(object sender, RoutedEventArgs e)
        {
            oep orderpage = new oep(lbox.SelectedItem as Customer);
            this.NavigationService.Navigate(orderpage);
            //Customer c = lbox.SelectedItem as Customer;
            //Console.WriteLine(c.Name);
        }
        public CustomerPage()
        {
            InitializeComponent();
            myobj.add(15, "spooky", 15, 12345);
            myobj.add(14, "scary", 12, 1234);
            myobj.add(13, "sneaky", 15, 12345);

            lbox.ItemsSource = myobj.clist;
        }
    }
}
