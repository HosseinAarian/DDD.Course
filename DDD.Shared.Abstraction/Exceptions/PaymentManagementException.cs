namespace DDD.Shared.Abstraction.Exceptions;

public abstract class PaymentManagementException : Exception
{
	protected PaymentManagementException(string message) : base(message) 
	{
		
	}
}
