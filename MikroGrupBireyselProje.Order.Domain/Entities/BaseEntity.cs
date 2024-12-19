namespace MikroGrupBireyselProje.Order.Domain.Entities;

public class BaseEntity<T>
{
    public T Id { get; set; } = default!;
}