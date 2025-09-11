using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.ValueObjects;

namespace DDD.Domain.Factories.CourseManagement;

public interface ICourseCatalogFactory
{
	CourseCatalog Create(BaseId id, Title title, Description description, BaseId courseId);
}
