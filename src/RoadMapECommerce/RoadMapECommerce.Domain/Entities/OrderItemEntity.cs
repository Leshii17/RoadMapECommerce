namespace RoadMapECommerce.Domain.Entities;

public class OrderItemEntity
{
	public Guid Id { get; }
	public Guid OrderId { get; }
	public Guid ProductId { get; }
	public uint Quantity { get; }
	public decimal PriceAtPurchase { get; }
	public OrderItemEntity(Guid orderId, Guid productId, uint quantity, decimal price)
	{
		Id = Guid.NewGuid();
		OrderId = orderId;
		ProductId = productId;
		Quantity = quantity;
		PriceAtPurchase = price;
	}
}
