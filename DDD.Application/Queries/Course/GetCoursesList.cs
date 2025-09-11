using DDD.Application.DTOs;
using DDD.Shared.Abstraction.Queries;

namespace DDD.Application.Queries.Course;

public class GetCoursesList : IQuery<IEnumerable<CourseDto>>
{
}
