using DDD.Domain.Entities.UserManagement;
using DDD.Domain.ValueObjects;

namespace DDD.Domain.Factories.UserManagement;

public class RoleFactory : IRoleFactory
{
	public Role Create(BaseId id, RoleName roleName)
	{
		return new Role(id, roleName);
	}
}
