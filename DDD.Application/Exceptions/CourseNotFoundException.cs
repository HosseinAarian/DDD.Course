using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Application.Exceptions;

public class CourseNotFoundException : CourseManagementException
{
	public CourseNotFoundException() : base("Course Not Found")
	{
	}
}
