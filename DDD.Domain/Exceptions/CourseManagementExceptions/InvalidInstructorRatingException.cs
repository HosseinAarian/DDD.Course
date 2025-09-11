using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exceptions.CourseManagementExceptions;

public class InvalidInstructorRatingException : CourseManagementException

{
	public InvalidInstructorRatingException() : base("Instructor Rate Can Not Be Negative")
	{
	}
}
