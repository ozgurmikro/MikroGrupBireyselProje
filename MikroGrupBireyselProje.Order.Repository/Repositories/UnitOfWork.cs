using MikroGrupBireyselProje.Order.Application.Contracts.Persistence;
using MikroGrupBireyselProje.Order.Repository;

namespace MikroGrupBireyselProje.Order.Persistence.Repositories;

internal class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    public Task<int> SaveChangesAsync()
    {
        return context.SaveChangesAsync();
    }
}