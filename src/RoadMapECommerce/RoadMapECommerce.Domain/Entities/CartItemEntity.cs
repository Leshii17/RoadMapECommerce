namespace RoadMapECommerce.Domain.Entities;

public class CartItemEntity
{
	public Guid Id { get; }

	public Guid ShoppingCartId { get; }

	public Guid ProductId { get; }

	public uint Quantity { get; }

	public CartItemEntity(Guid shoppingCartId, Guid productId, uint quantity)
	{
		Id = Guid.NewGuid();
		ShoppingCartId = shoppingCartId;
		ProductId = productId;
		Quantity = quantity;
	}
}
