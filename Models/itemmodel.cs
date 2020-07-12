using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class item
    {
        public int Item_Num { get; set; }
        public string Item_Name { get; set; }
        public int Item_Type { get; set; }
        public int Item_Quantity { get; set; }


        public item(int num, string name, int type , int quant)
        {
            Item_Num = num;
            Item_Name = name;
            Item_Type = type;
            Item_Quantity = quant;
        }
    }
}
