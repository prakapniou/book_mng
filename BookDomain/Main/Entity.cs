namespace BookDomain.Main;

public abstract class Entity:IAggregateRoot
{
    public Guid Id { get; set; }
}
