using System.Data.Entity;

namespace CreditMarket.Models
{
    public class UnionsDbContext: DbContext
    {
        public DbSet<ApprovedOrder> ApprovedOrders { get; set; }

        public UnionsDbContext() : base("name=UkrainianUnionsDb")
        {
        }

        public static UnionsDbContext Create()
        {
            return new UnionsDbContext();
        }
    }
   
}