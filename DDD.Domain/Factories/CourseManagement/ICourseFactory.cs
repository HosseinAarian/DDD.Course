using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.ValueObjects;

namespace DDD.Domain.Factories.CourseManagement;

public interface ICourseFactory
{
	Course Create(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId);
}
