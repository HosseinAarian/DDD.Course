
using DDD.Domain.Factories.UserManagement;
using DDD.Domain.Repositories.UserManagement;
using DDD.Shared.Abstraction.Commands;

namespace DDD.Application.Commands.User.Handlers;

public class AddUserHandler(IUserRepository repository, IUserFactory factory) : ICommandHandler<AddUser>
{
    public async Task HandleAsync(AddUser command)
    {
        var user = factory.Create(command.id, command.userName, command.password, command.email, command.isConfirmed);
        await repository.AddAsync(user);
    }
}
