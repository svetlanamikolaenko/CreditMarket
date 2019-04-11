using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace CreditMarket.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public DbSet<Loan> Loans { get; set; }
		public DbSet<Order> Orders { get; set; }

		public ApplicationDbContext()
			: base("DefaultConnection", throwIfV1Schema: false)
		{
		}

		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}
	}
}