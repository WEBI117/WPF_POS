using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class Order_DAL
    {
        public List<Order> orderList;
        
        public Order_DAL()
        {
            orderList = new List<Order>();
        }

        public void addItem(int num, int cust_ID_NUM, int amount)
        {
            Order temp = new Order(num, cust_ID_NUM, amount);
            orderList.Add(temp);
        }

        public void deleteItem(int num)
        {
            Console.WriteLine("deleting Item Number ", num);
        }
    }
}
