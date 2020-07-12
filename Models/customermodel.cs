using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Customer
    {
        public int ID_NUM { get; set; }
        public string Name{ get; set; }
        public int Age{ get; set; }
        public int Phone_Num{ get; set; }

        // Constructor to create Customer instance.
        public Customer(int id, string nam, int ag, int phone)
        {
            ID_NUM = id;
            Name = nam;
            Age = ag;
            Phone_Num = phone;
        }
    }
}
