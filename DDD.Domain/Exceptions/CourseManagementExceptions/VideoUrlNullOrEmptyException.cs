

using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exceptions.CourseManagementExceptions;

internal class VideoUrlNullOrEmptyException : CourseManagementException
{
	public VideoUrlNullOrEmptyException() : base("Video Name Can Not Be Empty")
	{
	}
}
