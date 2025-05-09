using Microsoft.EntityFrameworkCore;
using RoadMapECommerce.Domain.Entities;
using RoadMapECommerce.Infrastructure.Persistence.EntityConfigurations;

namespace RoadMapECommerce.Infrastructure;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

	public DbSet<UserEntity> Users { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
	}
}
