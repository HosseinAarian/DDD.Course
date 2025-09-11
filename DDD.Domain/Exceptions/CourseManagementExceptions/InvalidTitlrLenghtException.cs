

using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidTitlrLenghtException : CourseManagementException
{
	public InvalidTitlrLenghtException(int validLenght) : base($"Title Can Not Be More Than {validLenght} Charecter")
	{
	}
}
