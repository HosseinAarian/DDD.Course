using DDD.Application.DTOs;
using DDD.Shared.Abstraction.Queries;

namespace DDD.Application.Queries.Course;

public class SearchCourseByPhrase : IQuery<IEnumerable<CourseDto>>
{
}
