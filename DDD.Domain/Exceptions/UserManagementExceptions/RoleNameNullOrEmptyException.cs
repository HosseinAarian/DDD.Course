using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exceptions.UserManagementExceptions;

internal class RoleNameNullOrEmptyException : UserManagementException
{
	public RoleNameNullOrEmptyException() : base("RoleName Can Not Be Empty")
	{
	}
}
