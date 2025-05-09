namespace RoadMapECommerce.Application.Services;

public interface IPasswordEncryptor
{
	string Encrypt(string password);

	bool Verify(string password, string hashedPassword);
}
