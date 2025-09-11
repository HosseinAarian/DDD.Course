using DDD.Shared.Abstraction.Exceptions;
namespace DDD.Domain.Exceptions.CourseManagementExceptions;

internal class InvalidDescriptionLenghtException : CourseManagementException
{
	public InvalidDescriptionLenghtException(int validLenght) : base($"Description Can Not Be More Than {validLenght} Characters")
	{
	}
}
