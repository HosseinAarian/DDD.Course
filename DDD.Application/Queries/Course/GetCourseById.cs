using DDD.Application.DTOs;
using DDD.Shared.Abstraction.Queries;

namespace DDD.Application.Queries.Course;

public class GetCourseById : IQuery<CourseDto>
{
	public Guid CourseId { get; set; }
}
