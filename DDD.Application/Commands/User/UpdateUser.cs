using DDD.Domain.ValueObjects;
using DDD.Shared.Abstraction.Commands;

namespace DDD.Application.Commands.User;

public record UpdateUser(BaseId id, UserName userName, Password password, Email email, bool isConfirmed) : ICommand;
