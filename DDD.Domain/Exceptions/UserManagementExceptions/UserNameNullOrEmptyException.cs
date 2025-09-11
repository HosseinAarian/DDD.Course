using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exceptions.UserManagementExceptions;

internal class UserNameNullOrEmptyException : UserManagementException
{
	public UserNameNullOrEmptyException() : base("UserName Can Not Be Empty")
	{
	}
}
