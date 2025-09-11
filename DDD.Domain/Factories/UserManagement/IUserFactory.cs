using DDD.Domain.Entities.UserManagement;
using DDD.Domain.ValueObjects;

namespace DDD.Domain.Factories.UserManagement;

public interface IUserFactory
{
	User Create(BaseId id, UserName userName, Password password, Email email, bool isConfirmed);
}
