namespace RoadMapECommerce.Application.Services;

internal class PasswordEncryptor : IPasswordEncryptor
{
	public string Encrypt(string password)
	{
		if (string.IsNullOrEmpty(password))
			throw new ArgumentException("Password cannot be null or empty.", nameof(password));

		return BCrypt.Net.BCrypt.HashPassword(password);
	}

	public bool Verify(string password, string hashedPassword)
	{
		if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(hashedPassword))
			throw new ArgumentException("Password cannot be null or empty.", nameof(password));

		return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
	}
}
