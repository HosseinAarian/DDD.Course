using DDD.Infrastructure.EF.Models.UserManagement;

namespace DDD.Infrastructure.EF.Models.CourseManagement;

public class CoureseAttendeReadModel : BaseReadModel
{
	public Guid UserId { get; set; }
	public UserReadModel User { get; set; }

	public Guid CourseId { get; set; }
	public CourseReadModel Course { get; set; }
}
