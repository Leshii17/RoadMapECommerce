namespace RoadMapECommerce.Application.DTOs.Users;

public class GetUserDTO
{
	public int Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public string? Email { get; set; }
	public string? Phone { get; set; }
	public string Role { get; set; } = string.Empty;
}
