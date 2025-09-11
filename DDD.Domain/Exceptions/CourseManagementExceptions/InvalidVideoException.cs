using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidVideoException : CourseManagementException
{
	public InvalidVideoException() : base("Only .mp4 Is Valid Extension For Videos")
	{
	}
}
