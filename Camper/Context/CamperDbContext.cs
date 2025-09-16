using System.Data.Entity;
using Camper.Models;

namespace Camper.Context
{ 

	public class CamperDbContext : DbContext
	{
		public CamperDbContext() : base("name=DefaultConnection")
		{
		}

		public DbSet<Camper.Models.Camper> Campers { get; set; }
		public DbSet<Camper.Models.CamperLog> CamperLogs { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
            modelBuilder.Entity<CamperLog>()
            .HasRequired(l => l.Camper)
            .WithMany(c => c.Logs)
            .HasForeignKey(l => l.CamperId);

			base.OnModelCreating(modelBuilder);
        }
    }
}