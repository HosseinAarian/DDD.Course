using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.ValueObjects;

namespace DDD.Domain.Factories.CourseManagement;

public class LessonFactory : ILessonFactory
{
	public Lesson Create(BaseId id, Title title, VideoUrl videoUrl, BaseId courseCatalogId)
	{
		return new Lesson(id, title, videoUrl, courseCatalogId);
	}
}
