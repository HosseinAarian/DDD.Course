using DDD.Domain.Exceptions.CourseManagementExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects;

public record Title
{
	public string Value { get;}
	private int _validLenght = 50;

	public Title(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			throw new TitleNullOrEmptyException();
		}

		if (value.Length > _validLenght)
		{
			throw new InvalidTitlrLenghtException(_validLenght);
		}

		Value = value;
	}

	public static implicit operator string(Title title) => title.Value;
	public static implicit operator Title(string title) => new(title);
}
