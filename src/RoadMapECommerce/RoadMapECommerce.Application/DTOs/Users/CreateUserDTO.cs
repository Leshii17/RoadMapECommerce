using RoadMapECommerce.Domain.Entities;

namespace RoadMapECommerce.Application.DTOs.Users;

public class CreateUserDTO
{
	public string Name { get; set; } = string.Empty;
	public string? Email { get; set; }
	public string? Phone { get; set; }
	public string Password { get; set; } = string.Empty;
	public UserRole Role { get; set; } = UserRole.User;
}
