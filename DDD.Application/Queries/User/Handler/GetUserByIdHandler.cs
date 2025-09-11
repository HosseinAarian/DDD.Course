using DDD.Application.DTOs;
using DDD.Shared.Abstraction.Queries;

namespace DDD.Application.Queries.User.Handler;

public class GetUserByIdHandler : IQueryHandler<GetUserById, UserDto>
{
	Task<UserDto> IQueryHandler<GetUserById, UserDto>.HandleAsync(GetUserById query)
	{
		throw new NotImplementedException();
	}
}
	
	
