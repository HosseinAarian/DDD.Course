using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exceptions.CourseManagementExceptions;

public class InvalidInstructorExprienceException : CourseManagementException
{
	public InvalidInstructorExprienceException() : base("Exprience Can Not Be Less Than 3 Years")
	{
	}
}
