using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        public int Order_Num { get; set; }
        public int cust_ID_NUM { get; set; }
        public int Amount{ get; set; }
        //Add order Item Class reference

        public Order(int onum, int cid, int amnt)
        {
            Order_Num = onum;
            cust_ID_NUM = cid;
            Amount = amnt;
            
        }
    }
}
