using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exceptions.UserManagementExceptions;

internal class InvalidEmailException : UserManagementException
{
	public InvalidEmailException() : base("Email Is Invalid")
	{
	}
}
