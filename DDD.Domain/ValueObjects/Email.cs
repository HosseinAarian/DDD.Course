using DDD.Domain.Exceptions.UserManagementExceptions;
using System.Text.RegularExpressions;

namespace DDD.Domain.ValueObjects;

public record Email
{
	public string Value { get; }
	private int _validLenght = 50;

	public Email(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			throw new EmailNullOrEmptyException();
		}

		var emailAddress = new System.Net.Mail.MailAddress(value);

		if (emailAddress.Address != value)
		{
			throw new InvalidEmailException();
		}

		Value = value;
	}

	public static implicit operator string(Email email) => email.Value;
	public static implicit operator Email(string email) => new(email);
}
