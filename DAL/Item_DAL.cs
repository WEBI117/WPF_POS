using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class Item_DAL
    {
        public List<item> itemList;
        
        public Item_DAL()
        {
            itemList = new List<item>();
        }

        public void addItem(int num, string name, int type, int quant)
        {
            item temp = new item(num, name, type, quant);
            itemList.Add(temp);
        }

        public void deleteItem(int num)
        {
            Console.WriteLine("deleting Item Number ", num);
        }
    }
}
