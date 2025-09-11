namespace DDD.Shared.Abstraction.Exceptions;

public abstract class UserManagementException : Exception
{
	protected UserManagementException(string message) : base(message)
	{
		
	}
}
