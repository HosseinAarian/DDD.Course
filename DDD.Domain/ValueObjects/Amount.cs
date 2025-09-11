using DDD.Domain.Exceptions.CourseManagementExceptions;

namespace DDD.Domain.ValueObjects;

public record Amount
{
	public decimal Value { get; }

	public Amount(decimal value)
	{
		if (value < 0)
		{
			throw new InvalidAmountException();
		}

		Value = value;
	}

	public static implicit operator decimal(Amount amount) => amount.Value;
	public static implicit operator Amount(decimal amount) => new(amount);
}
