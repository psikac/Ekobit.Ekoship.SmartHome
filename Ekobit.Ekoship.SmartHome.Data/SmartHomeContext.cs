using Ekobit.Ekoship.SmartHome.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Ekobit.Ekoship.SmartHome.Data
{
	public class SmartHomeContext : DbContext
	{
		public SmartHomeContext(DbContextOptions<SmartHomeContext> options) : base(options)
		{ }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Address>(address =>
			{
				address.HasKey(a => a.Id);

				address.HasMany(a => a.Homes).WithOne(h => h.Address);

				address.HasData(Data.InitialData.Addresses);
			});

			modelBuilder.Entity<Home>(home =>
			{
				home.HasKey(h => h.Id);

				home.HasData(Data.InitialData.Homes);
			});
		}

		public DbSet<Home> Homes { get; set; } = null!;

		public DbSet<Address> Addresses { get; set; } = null!;
	}
}
