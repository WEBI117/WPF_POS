using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace BAL
{
    public class customer_List
    {
        private Customer_DAL list;
        public ObservableCollection<Customer> clist;

        public customer_List()
        {
            list= new Customer_DAL();
            this.setList();
        }

        public void setList()
        {
            clist = new ObservableCollection<Customer>(list.custList);
        }

        public void add(int id, string name, int age, int phone)
        {
            int check = 0;
            for (int x = 0; x < clist.Count; x++)
            {
                if (clist[x].ID_NUM == id)
                {
                    check++;
                }
            }
            if (check == 0)
            {
                clist.Add(new Customer(id, name, age, phone));
            }
        }

        public void delete(int id)
        {
            for (int x = 0; x < list.custList.Count; x++)
            {
                if (list.custList[x].ID_NUM == id)
                {
                    list.custList.Remove(list.custList[x]);
                }
            }
            this.setList();
        }

        public void show()
        {
            int x = clist.Count;
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(clist[i].Name);
            }
        }
    }
}
