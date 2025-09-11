using DDD.Application.DTOs;
using DDD.Shared.Abstraction.Queries;

namespace DDD.Application.Queries.User;

public class GetUsersList : IQuery<IEnumerable<UserDto>>
{
}
