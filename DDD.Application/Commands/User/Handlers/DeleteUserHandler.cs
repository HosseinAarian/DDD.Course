using DDD.Application.Exceptions;
using DDD.Domain.Repositories.UserManagement;
using DDD.Shared.Abstraction.Commands;

namespace DDD.Application.Commands.User.Handlers;

public class DeleteUserHandler(IUserRepository repository) : ICommandHandler<DeleteUser>
{
    public async Task HandleAsync(DeleteUser command)
    {
        var user = await repository.GetAsync(command.Id);
        if (user == null)
        {
            throw new UserNotFoundException();
        }
        await repository.DeleteAsync(user);
    }
}
