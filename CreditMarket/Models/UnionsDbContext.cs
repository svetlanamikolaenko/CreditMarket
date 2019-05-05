using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CreditMarket.Models
{
    public class UnionsDbContext: DbContext
    {
        public UnionsDbContext() : base("name=UkrainianUnionsDb")
        {
           
        }
        public DbSet<ApprovedOrder> ApprovedOrders { get; set; }
    }
   
}