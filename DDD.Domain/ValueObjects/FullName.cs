using DDD.Domain.Exceptions.CourseManagementExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects;

public record FullName
{
	private int _ValidLenght = 30;
	public string Value { get; }

	public FullName(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			throw new FullNameNullOrEmptyException();
		}

		if (value.Length > _ValidLenght)
		{
			throw new InvalidFullNameLenghtException(_ValidLenght);
		}

		Value = value;
	}

	public static implicit operator string(FullName fullName) => fullName.Value;
	public static implicit operator FullName(string fullName) => new(fullName);
}
