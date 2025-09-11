using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.Exceptions.CourseManagementExceptions;
using DDD.Domain.ValueObjects;

namespace DDD.Domain.Factories.CourseManagement;

public class InstructorFactory : IInstructorFactory
{
	public Instructor CreateWithoutExprienceAndRating(BaseId id, FullName fullName, Biography bio, int exprience)
	{
		return new Instructor(id, fullName, bio, exprience);
	}

	public Instructor CreateWithExprienceAndWithoutRating(BaseId id, FullName fullName, Biography bio, int exprience)
	{
		if (exprience < 3)
		{
			throw new InvalidInstructorExprienceException();
		}
		return new Instructor(id,fullName, bio, exprience);
	}

	public Instructor CreateWithExprienceAndRating(BaseId id, FullName fullName, Biography bio, int exprience, double rating)
	{
		if (exprience < 3)
		{
			throw new InvalidInstructorExprienceException();
		}
		if (exprience < 0)
		{
			throw new InvalidInstructorRatingException();
		}
		return new Instructor(id, fullName, bio, exprience, rating);
	}
}
