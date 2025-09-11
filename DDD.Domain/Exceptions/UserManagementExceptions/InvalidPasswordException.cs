using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exceptions.UserManagementExceptions;

internal class InvalidPasswordException : UserManagementException
{
	public InvalidPasswordException() : base("Password Is Invalid")
	{
	}
}
