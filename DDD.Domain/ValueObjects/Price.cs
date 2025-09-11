using DDD.Domain.Exceptions.CourseManagementExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects;

public record Price
{
	public decimal Value { get; }

	public Price(decimal value)
	{
		if (value < 0)
		{
			throw new InvalidPriceException();
		}

		Value = value;
	}

	public static implicit operator decimal(Price price) => price.Value;
	public static implicit operator Price(decimal price) => new(price);
}
