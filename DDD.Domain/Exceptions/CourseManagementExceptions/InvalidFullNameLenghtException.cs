

using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidFullNameLenghtException : CourseManagementException
{
	public InvalidFullNameLenghtException(int validLenght) : base($"FullName Can Not Be More Than {validLenght} Charecters")
	{
	}
}
