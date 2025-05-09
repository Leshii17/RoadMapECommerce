using System.Text.Json.Serialization;

namespace RoadMapECommerce.Domain.Entities;

public class UserEntity
{
	public Guid Id { get; }

	public string Name { get; }

	public string? Email { get; }

	public string? Phone { get; }

	[JsonIgnore]
	public string PasswordHash { get; }

	public UserRole Role { get; }

	public UserEntity(string name, string? email, string? phone, string passwordHash, UserRole role)
	{
		if (string.IsNullOrWhiteSpace(name))
			throw new ArgumentNullException(nameof(name), "Name cannot be null or empty.");

		if (string.IsNullOrWhiteSpace(passwordHash))
			throw new ArgumentNullException(nameof(passwordHash), "Password hash cannot be null or empty.");

		if (string.IsNullOrWhiteSpace(email) && string.IsNullOrWhiteSpace(phone))
			throw new ArgumentNullException("Either email or phone must be provided.");

		Id = Guid.NewGuid();
		Name = name;
		Email = email;
		Phone = phone;
		PasswordHash = passwordHash;
		Role = role;
	}
}

public enum UserRole
{
	Admin,
	User
}
