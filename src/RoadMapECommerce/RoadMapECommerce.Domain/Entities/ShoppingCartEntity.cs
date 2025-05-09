namespace RoadMapECommerce.Domain.Entities;

public class ShoppingCartEntity
{
	public Guid Id { get; }

	public Guid UserId { get; }

	public ShoppingCartStatus Status { get => _status; }

	public DateTime UpdatedDate { get => _updatedDate; }

	private ShoppingCartStatus _status = ShoppingCartStatus.Active;
	private DateTime _updatedDate = DateTime.UtcNow;

	public ShoppingCartEntity(Guid userId)
	{
		Id = Guid.NewGuid();
		UserId = userId;
	}

	public void UpdateStatus(ShoppingCartStatus status)
	{
		_status = status;
		_updatedDate = DateTime.UtcNow;
	}
}

public enum ShoppingCartStatus
{
	Active,
	Saved,
	Abandoned,
	CheckingOut,
	Completed,
}
