using DDD.Domain.Entities.UserManagement;
using DDD.Shared.Abstraction.Domain;

namespace DDD.Domain.DomainEvents;

public record UserRegistered(User user) : IDomainEvent;


