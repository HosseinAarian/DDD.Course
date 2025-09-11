using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.ValueObjects;

namespace DDD.Domain.Factories.CourseManagement;

public interface ICourseAttendeeFactory
{
	CourseAttende Creste(BaseId id, BaseId courseId, BaseId userId);
}
