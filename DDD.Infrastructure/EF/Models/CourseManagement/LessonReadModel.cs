namespace DDD.Infrastructure.EF.Models.CourseManagement;

public class LessonReadModel : BaseReadModel
{
	public string Title { get; set; }
	public string VideoUrl { get; set; }
	public Guid catalogId { get; set; }
	public CoureseCatalogReadModel CourseCatalog { get; set; }

}
