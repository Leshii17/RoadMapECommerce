using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoadMapECommerce.Domain.Entities;

namespace RoadMapECommerce.Infrastructure.Persistence.EntityConfigurations;

internal class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
	public void Configure(EntityTypeBuilder<UserEntity> builder)
	{
		builder.HasKey(e => e.Id);

		builder.Property(e => e.Name)
		.IsRequired()
		.IsUnicode()
		.HasMaxLength(255);

		builder.Property(e => e.Email)
		.IsRequired(false)
		.IsUnicode()
		.HasMaxLength(320);

		builder.Property(e => e.Phone)
		.IsRequired(false)
		.IsUnicode()
		.HasMaxLength(15);

		builder.Property(e => e.PasswordHash)
		.IsRequired()
		.IsUnicode()
		.HasMaxLength(255);

		builder.Property(e => e.Role)
		.IsRequired();
	}
}
