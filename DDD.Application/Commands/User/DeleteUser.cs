using DDD.Domain.ValueObjects;
using DDD.Shared.Abstraction.Commands;

namespace DDD.Application.Commands.User;

public record DeleteUser(BaseId Id) : ICommand;

