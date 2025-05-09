using RoadMapECommerce.Domain.Entities;
using RoadMapECommerce.Domain.Interfaces.Repositories;
using System.Threading;

namespace RoadMapECommerce.Infrastructure.Persistence.Repositories;

internal class UserRepository : IUserRepository
{
	private readonly AppDbContext _context;

	public UserRepository(AppDbContext context)
	{
		_context = context ?? throw new ArgumentNullException(nameof(context));
	}

	public async Task AddUserAsync(UserEntity user, CancellationToken cancellationToken = default)
	{
		await _context.Users.AddAsync(user, cancellationToken);
	}

	public Task DeleteUserAsync(UserEntity user)
	{
		_context.Users.Remove(user);
		return Task.CompletedTask;
	}

	public async Task<UserEntity?> GetUserByIdAsync(int id, CancellationToken cancellationToken = default)
	{
		return await _context.Users.FindAsync([id], cancellationToken: cancellationToken);
	}

	public Task UpdateUserAsync(UserEntity user)
	{
		_context.Users.Update(user);
		return Task.CompletedTask;
	}
}
