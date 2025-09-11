using DDD.Application.DTOs;
using DDD.Shared.Abstraction.Queries;

namespace DDD.Application.Queries.Course.Handler;

public class GetCourseByIdHandler : IQueryHandler<GetCourseById, CourseDto>
{
	public Task<CourseDto> HandleAsync(GetCourseById query)
	{
		throw new NotImplementedException();
	}
}
