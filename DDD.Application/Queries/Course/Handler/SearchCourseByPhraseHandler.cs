using DDD.Application.DTOs;
using DDD.Domain.Entities.CourseManagement;
using DDD.Shared.Abstraction.Queries;

namespace DDD.Application.Queries.Course.Handler;

public class SearchCourseByPhraseHandler : IQueryHandler<SearchCourseByPhrase, IEnumerable<CourseDto>>
{
	public Task<IEnumerable<CourseDto>> HandleAsync(SearchCourseByPhrase query)
	{
		throw new NotImplementedException();
	}
}
