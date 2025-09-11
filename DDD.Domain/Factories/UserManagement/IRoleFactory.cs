using DDD.Domain.Entities.UserManagement;
using DDD.Domain.ValueObjects;

namespace DDD.Domain.Factories.UserManagement;

public interface IRoleFactory
{
	Role Create(BaseId id, RoleName roleName);
}
