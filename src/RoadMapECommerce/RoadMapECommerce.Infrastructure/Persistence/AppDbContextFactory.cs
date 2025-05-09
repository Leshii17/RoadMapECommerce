using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RoadMapECommerce.Infrastructure.Persistence;

internal class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
	public AppDbContext CreateDbContext(string[] args)
	{
		var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
		optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RoadmapECommerce;ConnectRetryCount=0");

		return new AppDbContext(optionsBuilder.Options);
	}
}
