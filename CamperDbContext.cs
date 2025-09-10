using System.Data.Entity;
using Camper.Models

namespace Camper.Context
{ 

	public class CamperDbContext : DbContext
	{
		public CamperDbContext() : base("name=DefaultConnection")
		{
		}

		public DbSet<Camper> Campers { get; set; }
	}
}