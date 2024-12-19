using Microsoft.EntityFrameworkCore;
using MikroGrupBireyselProje.Order.Application.Contracts.Persistence;
using MikroGrupBireyselProje.Order.Repository;

namespace MikroGrupBireyselProje.Order.Persistence.Repositories;

internal class OrderRepository(AppDbContext context)
    : GenericRepository<Domain.Entities.Order, Guid>(context), IOrderRepository
{
    public Task<List<Domain.Entities.Order>> GetOrdersByUserIdAsync(Guid userId)
    {
        return Context.Orders.Include(x => x.OrderItems).Where(x => x.BuyerId == userId).ToListAsync();
    }
}