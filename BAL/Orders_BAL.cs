using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
using System.Collections.ObjectModel;

namespace BAL
{
    public class Order_List
    {
        private Order_DAL DAL_item;
        public  ObservableCollection<Order> olist;

        public Order_List()
        {
            DAL_item= new Order_DAL();
            this.setList();
        }

        public void setList()
        {
            olist = new ObservableCollection<Order>(DAL_item.orderList);
        }

        public void add(int onum, int cid, int amnt)
        {
            int check = 0;
            for (int x = 0; x < olist.Count; x++)
            {
                if (olist[x].Order_Num == onum)
                {
                    check++;
                }
            }
            if (check == 0)
            {
                olist.Add(new Order(onum, cid, amnt));
            }
        }

        public void delete(int id)
        {
            this.DAL_item.deleteItem(id);
            this.setList();
        }

        public void show()
        {
            int x = olist.Count;
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(olist[i].Order_Num);
            }
        }
    }
}
