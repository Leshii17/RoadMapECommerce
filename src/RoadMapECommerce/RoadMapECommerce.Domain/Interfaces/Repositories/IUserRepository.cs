using RoadMapECommerce.Domain.Entities;

namespace RoadMapECommerce.Domain.Interfaces.Repositories;

public interface IUserRepository
{
	Task<UserEntity?> GetUserByIdAsync(int id, CancellationToken cancellationToken = default);
	Task AddUserAsync(UserEntity user, CancellationToken cancellationToken = default);
	Task UpdateUserAsync(UserEntity user);
	Task DeleteUserAsync(UserEntity user);
}
