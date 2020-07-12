using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    // Customer object class.

    // Class returned to BAL.
    public class Customer_DAL
    {
        public List<Customer> custList;

        // Constructor to create new customer list.
        public Customer_DAL()
        {
            custList = new List<Customer>();
        }

        // Add a customer object to the list.
        public void addCust(int id, string nam, int ag, int phone)
        {
            custList.Add(new Customer(id, nam, ag, phone));
        }

        // Delete a customer object from the list based on ID.
        public void deleteCust(int id)
        {
            Console.WriteLine("deleting customer", id);
        }
    }
}
