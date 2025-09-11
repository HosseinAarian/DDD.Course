using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.ValueObjects;

namespace DDD.Domain.Factories.CourseManagement;

public interface ILessonFactory
{
	Lesson Create(BaseId id, Title title, VideoUrl videoUrl, BaseId courseCatalogId);
}
