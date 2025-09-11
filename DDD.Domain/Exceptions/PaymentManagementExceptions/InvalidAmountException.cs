using DDD.Shared.Abstraction.Exceptions;

internal class InvalidAmountException : PaymentManagementException
{
	public InvalidAmountException() : base("Amount Can Not Be Negative")
	{
	}
}
