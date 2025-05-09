namespace RoadMapECommerce.Domain.Entities;

public class PaymentEntity
{
	public Guid Id { get; }
	public Guid OrderId { get; }
	public Guid TransactionId { get; }
	public decimal Amount { get; }
	public DateTime CreatedAt { get; }
	public PaymentStatus Status { get => _status; }
	public DateTime UpdatedDate { get => _updatedDate; }

	private PaymentStatus _status = PaymentStatus.Pending;
	private DateTime _updatedDate = DateTime.UtcNow;

	public PaymentEntity(Guid orderId, decimal amount)
	{
		if (amount <= 0)
			throw new ArgumentException("Amount must be greater than zero.", nameof(amount));

		Id = Guid.NewGuid();
		OrderId = orderId;
		Amount = amount;
		CreatedAt = DateTime.UtcNow;
	}

	public void UpdateStatus(PaymentStatus status)
	{
		_status = status;
		_updatedDate = DateTime.UtcNow;
	}
}

public enum PaymentStatus
{
	Pending,
	Completed,
	Failed,
	Refunded,
}
