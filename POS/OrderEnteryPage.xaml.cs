using BAL;
using Models;
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

namespace POS_app
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class oep : Page
    {
        Customer currcust;
        item_List inventory;
        item_List selected;
        Order finalOrder;
        public void ADDbuttonhandler(object sender, RoutedEventArgs e)
        {
            item selection = menubox.SelectedItem as item;
            try
            {
                if (!selected.contains(selection.Item_Num) && selection.Item_Quantity != 0)
                {
                    selected.add(selection.Item_Num, selection.Item_Name, selection.Item_Type, selection.Item_Quantity);
                    inventory.updateQuantity(selection.Item_Num, -1);
                    selected.updateQuantity(selection.Item_Num, -1);
                    selecteditemBox.ItemsSource = selected.ilist;
                    menubox.ItemsSource = inventory.ilist;
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }

        public void CLEARButtonhandler(object sender, RoutedEventArgs e)
        {
            if(selecteditemBox.SelectedItem == null)
            {
                while(selected.ilist.Count != 0)
                {
                    int num = selected.ilist[0].Item_Num;
                    inventory.updateQuantity(num, 1);
                    selected.delete(num);
                }
                selecteditemBox.ItemsSource = selected.ilist;
                menubox.ItemsSource = inventory.ilist;
            }
            else
            {
                item temp = selecteditemBox.SelectedItem as item;
                int num = temp.Item_Num;
                inventory.updateQuantity(num, 1);
                selected.delete(num);
                selecteditemBox.ItemsSource = selected.ilist;
                menubox.ItemsSource = inventory.ilist;
            }
        }
        public oep(Customer cust)
        {
            InitializeComponent();
            currcust = cust;
            inventory = new item_List();
            selected = new item_List();
            inventory.add(1, "yummy Dish", 12, 13);
            inventory.add(2, "spooky Dish", 12, 13);
            inventory.add(3, "silly Dish", 12, 13);
            selected.add(7, "something Dish", 12, 13);
            inventory.add(4, "yummy Dish", 12, 13);
            inventory.add(5, "spooky Dish", 12, 13);
            inventory.add(6, "silly Dish", 12, 13);
            menubox.ItemsSource = inventory.ilist;
            selecteditemBox.ItemsSource = selected.ilist;
        }
    }
}
