using DDD.Application.DTOs;
using DDD.Shared.Abstraction.Queries;

namespace DDD.Application.Queries.User.Handler;

public class GetUserListHandler : IQueryHandler<GetUsersList, IEnumerable<UserDto>>
{
	Task<IEnumerable<UserDto>> IQueryHandler<GetUsersList, IEnumerable<UserDto>>.HandleAsync(GetUsersList query)
	{
		throw new NotImplementedException();
	}
}
