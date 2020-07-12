using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BAL
{
    public class item_List
    {
        private Item_DAL DAL_item;
        public ObservableCollection<item> ilist;

        public item_List()
        {
            DAL_item = new Item_DAL();
            this.setList();
        }

        public void setList()
        {
            ilist = new ObservableCollection<item>(DAL_item.itemList);
        }

        public void add(int num, string name, int type, int quant)
        {
            DAL_item.addItem(num, name, type, quant);
            setList();
        }
        public void delete(int num)
        {
            this.DAL_item.deleteItem(num);
            this.setList();
        }

        public void show()
        {
            int x = ilist.Count;
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(ilist[i].Item_Num);
            }
        }
        public bool contains(int num)
        {
            for(int x = 0; x < DAL_item.itemList.Count; x++)
            {
                if(DAL_item.itemList[x].Item_Num == num)
                {
                    return true;
                }
            }
            return false;
        }
        public void updateQuantity(int num, int difference)
        {
            for(int x = 0; x < DAL_item.itemList.Count; x++)
            {
                if(DAL_item.itemList[x].Item_Num == num)
                {
                    DAL_item.itemList[x].Item_Quantity = DAL_item.itemList[x].Item_Quantity+difference;  
                }
                this.setList();
            }
        }
    }
}
