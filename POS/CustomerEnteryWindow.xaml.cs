using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Windows.Controls.Primitives;
using BAL;

namespace POS
{
    /// <summary>
    /// Interaction logic for CustomerEnteryWindow.xaml
    /// </summary>
    public partial class CustomerEnteryWindow : Window
    {
        public Customer LocalCustomer;
        public int id;
        public string name;
        public  int age;
        public  int num;
        public int check = 0;
        public customer_List mydata;

        public void submitbuttonHandle(object sender, RoutedEventArgs e)
        {
            try
            {
                this.id = Int32.Parse(identery.Text);
                this.name = nameentery.Text;
                this.age = Int32.Parse(ageentery.Text);
                this.num = Int32.Parse(Phoneentry.Text);

                mydata.add(id, name, age, num);
                this.Close();
            }
            catch(Exception err)
            {
                Console.WriteLine(err);
                MessageBox.Show("Incorrect Entry for 1 or more fields \n Try Again. \n");
            }
        }

        public CustomerEnteryWindow(customer_List data)
        {
            InitializeComponent();
            mydata = data;
        }
    }
}
