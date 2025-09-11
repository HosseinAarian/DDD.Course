
using DDD.Domain.Factories.UserManagement;
using DDD.Domain.Repositories.UserManagement;
using DDD.Shared.Abstraction.Commands;

namespace DDD.Application.Commands.User.Handlers;

public class AddUserHandler : ICommandHandler<AddUser>
{
	private readonly IUserRepository repository;
	private readonly IUserFactory factory;

	public AddUserHandler(IUserRepository repository, IUserFactory factory)
	{
		this.repository = repository;
		this.factory = factory;
	}
	public async Task HandleAsync(AddUser command)
	{
		var user = factory.Create(command.id, command.userName, command.password, command.email, command.isConfirmed);
		await repository.AddAsync(user);
	}
}
