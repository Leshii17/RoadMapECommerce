namespace RoadMapECommerce.Domain.Entities;

public class OrderEntity
{
	public Guid Id { get; }
	public Guid UserId { get; }
	public Guid CartId { get; }
	public DateTime CreatedAt { get; } = DateTime.UtcNow;
	public OrderStatus Status { get => _status; }
	public DateTime UpdatedDate { get => _updatedDate; }

	private OrderStatus _status = OrderStatus.Pending;
	private DateTime _updatedDate = DateTime.UtcNow;

	public OrderEntity(Guid userId, Guid paymentId)
	{
		Id = Guid.NewGuid();
		UserId = userId;
		CartId = paymentId;
	}

	public void UpdateStatus(OrderStatus status)
	{
		_status = status;
		_updatedDate = DateTime.UtcNow;
	}
}

public enum OrderStatus
{
	Pending,
	Completed,
	Cancelled,
	Refunded,
}
