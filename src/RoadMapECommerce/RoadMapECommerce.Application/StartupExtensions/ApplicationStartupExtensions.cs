using RoadMapECommerce.Application.Mediator.Users;
using RoadMapECommerce.Application.Services;

namespace Microsoft.Extensions.DependencyInjection;

public static class ApplicationStartupExtensions
{
	public static IServiceCollection AddMediator(this IServiceCollection services)
	{
		services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<CreateUserCommandHandler>());
		return services;
	}

	public static IServiceCollection AddServices(this IServiceCollection services)
	{
		services.AddScoped<IPasswordEncryptor, PasswordEncryptor>();
		return services;
	}
}
