using DDD.Domain.ValueObjects;

namespace DDD.Domain.Entities.UserManagement;

public class UserRole
{
	private BaseId _userId;
	private BaseId _roleId;

	internal UserRole(BaseId userId, BaseId roleId)
	{
		_userId = userId;
		_roleId = roleId;
	}

	public UserRole()
	{

	}
}
