using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.ValueObjects;

namespace DDD.Domain.Factories.CourseManagement;

public class CourseCatalogFactory : ICourseCatalogFactory
{
	public CourseCatalog Create(BaseId id, Title title, Description description, BaseId courseId)
	{
		return new CourseCatalog(id, title, description, courseId);
	}
}
