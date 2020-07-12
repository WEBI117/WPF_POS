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
        private Customer_DAL DAL_item;
        public ObservableCollection<Customer> clist;

        public customer_List()
        {
            DAL_item= new Customer_DAL();
            this.setList();
        }

        public void setList()
        {
            clist = new ObservableCollection<Customer>(DAL_item.custList);
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
                DAL_item.addCust(id, name, age, phone);
                this.setList();
            }
        }

        public void delete(int id)
        {
            this.DAL_item.deleteCust(id);
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
