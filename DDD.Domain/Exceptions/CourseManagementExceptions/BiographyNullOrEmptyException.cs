using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exceptions.CourseManagementExceptions;

internal class BiographyNullOrEmptyException : CourseManagementException
{
	public BiographyNullOrEmptyException() : base("Biography Can Not Be Empty")
	{
	}
}
