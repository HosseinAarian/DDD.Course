using DDD.Application.Exceptions;
using DDD.Domain.Repositories.UserManagement;
using DDD.Shared.Abstraction.Commands;

namespace DDD.Application.Commands.User.Handlers;

public class DeleteUserHandler : ICommandHandler<DeleteUser>
{
	private readonly IUserRepository repository;

	public DeleteUserHandler(IUserRepository repository)
	{
		this.repository = repository;
	}
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
