using DDD.Application.DTOs;
using DDD.Shared.Abstraction.Queries;

namespace DDD.Application.Queries.Course.Handler;

public class GetCoursesListHandler : IQueryHandler<GetCoursesList, IEnumerable<CourseDto>>
{
	public Task<IEnumerable<CourseDto>> HandleAsync(GetCoursesList query)
	{
		throw new NotImplementedException();
	}
}
