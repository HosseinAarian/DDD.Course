using DDD.Domain.Exceptions.UserManagementExceptions;
using System.Text.RegularExpressions;

namespace DDD.Domain.ValueObjects;

public record Password
{
	public string Value { get; }
	private int _validLenght = 50;

	public Password(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			throw new PasswordNullOrEmptyException();
		}

		string pattern = "[^a-zA-z0-9]";

		var regex = new Regex(pattern);

		if (!regex.IsMatch(value))
		{
			throw new InvalidPasswordException();
		}

		Value = value;
	}

	public static implicit operator string(Password password) => password.Value;
	public static implicit operator Password(string password) => new(password);
}
