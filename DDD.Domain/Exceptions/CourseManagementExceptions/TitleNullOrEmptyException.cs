
using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exceptions.CourseManagementExceptions;

internal class TitleNullOrEmptyException : CourseManagementException
{
	public TitleNullOrEmptyException() : base("Title Can Not Be Empty")
	{
	}
}
