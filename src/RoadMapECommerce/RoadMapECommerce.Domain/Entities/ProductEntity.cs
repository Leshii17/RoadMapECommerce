namespace RoadMapECommerce.Domain.Entities;

public class ProductEntity
{
	public Guid Id { get; }
	public string Name { get; }
	public string? Description { get; }
	public decimal Price { get; }
	public string Category { get; }
	public uint Stock { get; }

	public ProductEntity(string name,  decimal price, string category, uint stock, string? description = null)
	{
		if (string.IsNullOrWhiteSpace(name))
			throw new ArgumentException("Product name cannot be null or empty.", nameof(name));

		if (string.IsNullOrWhiteSpace(category))
			throw new ArgumentException("Product category cannot be null or empty.", nameof(category));

		if (price <= 0)
			throw new ArgumentOutOfRangeException(nameof(price), "Product price must be greater than zero.");

		Id = Guid.NewGuid();
		Name = name;
		Description = description;
		Price = price;
		Category = category;
		Stock = stock;
	}
}
