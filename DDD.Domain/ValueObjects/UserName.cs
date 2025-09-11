using DDD.Domain.Exceptions.CourseManagementExceptions;
using DDD.Domain.Exceptions.UserManagementExceptions;

namespace DDD.Domain.ValueObjects;

public record UserName
{
	public string Value { get; }
	private int _validLenght = 50;

	public UserName(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			throw new UserNameNullOrEmptyException();
		}

		Value = value;
	}

	public static implicit operator string(UserName userName) => userName.Value;
	public static implicit operator UserName(string userName) => new(userName);
}
