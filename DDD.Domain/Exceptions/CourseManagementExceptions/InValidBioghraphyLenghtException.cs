using DDD.Shared.Abstraction.Exceptions;

namespace DDD.Domain.Exceptions.CourseManagementExceptions;

internal class InValidBioghraphyLenghtException : CourseManagementException
{
	public InValidBioghraphyLenghtException() : base("Bioghraphy Can Not Be More Than 300 Character")
	{
	}
}
