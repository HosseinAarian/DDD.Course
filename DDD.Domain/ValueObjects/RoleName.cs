using DDD.Domain.Exceptions.UserManagementExceptions;

namespace DDD.Domain.ValueObjects;

public record RoleName
{
	public string Value { get; }
	private int _validLenght = 50;

	public RoleName(string value)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			throw new RoleNameNullOrEmptyException();
		}

		Value = value;
	}

	public static implicit operator string(RoleName roleName) => roleName.Value;
	public static implicit operator RoleName(string roleName) => new(roleName);
}
