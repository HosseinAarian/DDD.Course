using DDD.Domain.ValueObjects;
using DDD.Shared.Abstraction.Commands;

namespace DDD.Application.Commands.User;

public record AddUser(BaseId id, UserName userName, Password password, Email email, bool isConfirmed)  : ICommand;

