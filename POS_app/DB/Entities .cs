using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_app.DB
{
    public class Customer
    {
        public int ID_name;
        public string Name;
        public int Age;
        public int Phone_num;

        public List<Order> orders;
    }

    public class Order
    {
        public int Order_Num;
        public int amount;

        public Customer customer;
    }

    public class OrderItem
    {
        public int Order_Num;
        public int Item_Num;
        public Order Order;
        public Item item;
    }
    
    public class Item
    {
        public int Item_Num;
        public int Item_Name;
        public int Item_Type;

        public OrderItem orderitem; 
    }
}
