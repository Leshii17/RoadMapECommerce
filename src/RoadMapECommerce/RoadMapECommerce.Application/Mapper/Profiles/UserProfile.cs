using AutoMapper;
using RoadMapECommerce.Application.DTOs.Users;
using RoadMapECommerce.Domain.Entities;

namespace RoadMapECommerce.Application.Mapper.Profiles;

internal class UserProfile : Profile
{
	public UserProfile()
	{
		//CreateMap<CreateUserDTO, UserEntity>()
		//	.ForMember(dest => dest.Id, opt => opt.Ignore())
		//	.ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
		//	.ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())
		//	.ForMember(dest => dest.DeletedAt, opt => opt.Ignore())
		//	.ForMember(dest => dest.IsDeleted, opt => opt.Ignore());
	}
}

