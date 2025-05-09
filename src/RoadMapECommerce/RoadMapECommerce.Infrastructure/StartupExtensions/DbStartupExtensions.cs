using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RoadMapECommerce.Domain.Interfaces;
using RoadMapECommerce.Domain.Interfaces.Repositories;
using RoadMapECommerce.Infrastructure;
using RoadMapECommerce.Infrastructure.Persistence;
using RoadMapECommerce.Infrastructure.Persistence.Repositories;

namespace Microsoft.Extensions.DependencyInjection;

public static class DbStartupExtensions
{
	public static IServiceCollection AddDataBase(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddDataBaseContext(configuration);
		services.AddScoped<IUserRepository, UserRepository>();
		services.AddScoped<IUnitOfWork, UnitOfWork<AppDbContext>>();
		return services;
	}

	private static IServiceCollection AddDataBaseContext(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddDbContextPool<AppDbContext>(options =>
		{
			options.UseSqlServer(configuration.GetConnectionString("DbConnection"));

#if DEBUG
			options.EnableSensitiveDataLogging();
#endif
		});

		return services;
	}
}
