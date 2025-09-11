using DDD.Domain.Exceptions.CourseManagementExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects;

public record Biography
{
	public string Value { get; }

	public Biography(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			throw new BiographyNullOrEmptyException();
		}

		if (value.Length > 300)
		{
			throw new InValidBioghraphyLenghtException();
		}

		Value = value;
	}

	public static implicit operator string(Biography biography) => biography.Value;
	public static implicit operator Biography(string biography) => new(biography);
}
