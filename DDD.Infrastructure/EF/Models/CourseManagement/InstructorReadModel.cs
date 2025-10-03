namespace DDD.Infrastructure.EF.Models.CourseManagement;

public class InstructorReadModel : BaseReadModel
{
	public string FullName { get; set; }
	public string Bio { get; set; }
	public int Exprience { get; set; }
	public double rating { get; set; }

	public IReadOnlyList<CourseReadModel> Courses { get; set; }
}
