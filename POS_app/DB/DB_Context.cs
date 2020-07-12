using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace POS_app.DB
{
    class POS : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem  { get; set; }
        public DbSet<Item> Item { get; set; }
    }
}
