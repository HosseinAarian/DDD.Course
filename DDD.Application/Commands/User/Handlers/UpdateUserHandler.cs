using DDD.Application.Exceptions;
using DDD.Domain.Factories.CourseManagement;
using DDD.Domain.Factories.UserManagement;
using DDD.Domain.Repositories.CourseManagement;
using DDD.Domain.Repositories.UserManagement;
using DDD.Shared.Abstraction.Commands;

namespace DDD.Application.Commands.User.Handlers;

public class UpdateUserHandler : ICommandHandler<UpdateUser>
{
	private readonly IUserRepository repository;
	private readonly IUserFactory factory;

	public UpdateUserHandler(IUserRepository repository, IUserFactory factory)
	{
		this.repository = repository;
		this.factory = factory;
	}

	public async Task HandleAsync(UpdateUser command)
	{
		var user = await repository.GetAsync(command.id);
		if (user == null)
		{
			throw new UserNotFoundException();
		}
		user =  factory.Create(user.Id, command.userName, command.password, command.email, command.isConfirmed);
	}
}
