using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exceptions.UserManagementExceptions;

internal class PasswordNullOrEmptyException : UserManagementException
{
	public PasswordNullOrEmptyException() : base("Password Can Not Be Empty")
	{
	}
}
