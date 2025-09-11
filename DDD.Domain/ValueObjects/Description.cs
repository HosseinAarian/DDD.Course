using DDD.Domain.Exceptions.CourseManagementExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects;

public record Description
{
	public string Value { get; }

	public Description(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			throw new DescriptionNullOrEmptyException();
		}

		if (value.Length > 50)
		{
			throw new InvalidDescriptionLenghtException(50);
		}

		Value = value;
	}

	public static implicit operator string(Description description) => description.Value;
	public static implicit operator Description(string description) => new(description);
}
