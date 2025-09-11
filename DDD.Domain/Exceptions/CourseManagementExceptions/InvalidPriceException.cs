

using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidPriceException : CourseManagementException
{
	public InvalidPriceException() : base("Price Can Not Be Negative")
	{
	}
}
