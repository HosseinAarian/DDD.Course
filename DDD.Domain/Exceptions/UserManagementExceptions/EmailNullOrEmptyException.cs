using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exceptions.UserManagementExceptions;

internal class EmailNullOrEmptyException : UserManagementException
{
	public EmailNullOrEmptyException() : base("Email Can Not Be Empty")
	{
	}
}
