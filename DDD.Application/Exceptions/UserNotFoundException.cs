using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Application.Exceptions;

public class UserNotFoundException : UserManagementException
{
	public UserNotFoundException() : base("User Not Found")
	{
	}
}
