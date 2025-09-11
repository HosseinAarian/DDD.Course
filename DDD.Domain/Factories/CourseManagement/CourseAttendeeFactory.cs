using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.ValueObjects;

namespace DDD.Domain.Factories.CourseManagement;

public class CourseAttendeeFactory : ICourseAttendeeFactory
{
	public CourseAttende Creste(BaseId id, BaseId courseId, BaseId userId)
	{
		return new CourseAttende(id, courseId, userId);
	}
}
