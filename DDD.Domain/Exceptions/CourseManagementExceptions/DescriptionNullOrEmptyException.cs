using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exceptions.CourseManagementExceptions;

internal class DescriptionNullOrEmptyException : CourseManagementException
{
	public DescriptionNullOrEmptyException() : base("Description Can Not Be Null Or Empty")
	{
	}
}
