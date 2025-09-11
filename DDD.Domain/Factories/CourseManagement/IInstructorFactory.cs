using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.ValueObjects;

namespace DDD.Domain.Factories.CourseManagement;

public interface IInstructorFactory
{
	Instructor CreateWithoutExprienceAndRating(BaseId id, FullName fullName, Biography bio, int exprience);
	Instructor CreateWithExprienceAndWithoutRating(BaseId id, FullName fullName, Biography bio, int exprience);
	Instructor CreateWithExprienceAndRating(BaseId id, FullName fullName, Biography bio, int exprience, double rating);
}
