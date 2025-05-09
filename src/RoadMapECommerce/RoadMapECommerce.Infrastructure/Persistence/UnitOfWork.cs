using Microsoft.EntityFrameworkCore;
using RoadMapECommerce.Domain.Interfaces;

namespace RoadMapECommerce.Infrastructure.Persistence;

internal class UnitOfWork<TContext> : IUnitOfWork where TContext : DbContext
{
	private readonly TContext _context;

	public UnitOfWork(TContext context)
	{
		_context = context ?? throw new ArgumentNullException(nameof(context));
	}

	public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
	{
		return await _context.SaveChangesAsync(cancellationToken);
	}
}
