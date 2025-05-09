using MediatR;
using RoadMapECommerce.Application.DTOs.Users;
using RoadMapECommerce.Application.Services;
using RoadMapECommerce.Domain.Entities;
using RoadMapECommerce.Domain.Interfaces;
using RoadMapECommerce.Domain.Interfaces.Repositories;

namespace RoadMapECommerce.Application.Mediator.Users;

public record CreateUserCommand(CreateUserDTO CreateUserDTO) : IRequest<UserEntity?>;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserEntity?>
{
	private readonly IUserRepository _userRepository;
	private readonly IPasswordEncryptor _passwordEncryptor;
	private readonly IUnitOfWork _unitOfWork;

	public CreateUserCommandHandler(IUserRepository userRepository, IPasswordEncryptor passwordEncryptor, IUnitOfWork unitOfWork)
	{
		_userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
		_passwordEncryptor = passwordEncryptor ?? throw new ArgumentNullException(nameof(passwordEncryptor));
		_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
	}

	public async Task<UserEntity?> Handle(CreateUserCommand request, CancellationToken cancellationToken)
	{
		var createUserDTO = request.CreateUserDTO;

		var user = new UserEntity(
			createUserDTO.Name, 
			createUserDTO.Email, 
			createUserDTO.Phone, 
			_passwordEncryptor.Encrypt(createUserDTO.Password), 
			createUserDTO.Role);

		await _userRepository.AddUserAsync(user);

		await _unitOfWork.SaveChangesAsync(cancellationToken);

		return user;
	}
}

