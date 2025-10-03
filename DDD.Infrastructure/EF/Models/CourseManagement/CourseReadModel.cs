namespace DDD.Infrastructure.EF.Models.CourseManagement;

public class CourseReadModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string description { get; set; }
    public bool IsFree { get; set; }
    public decimal Price { get; set; }
    public Guid InstructureId { get; set; }

    public IReadOnlyList<CoureseAttendeReadModel> CourseAttendees { get; set; }
    public IReadOnlyList<CoureseCatalogReadModel> CourseCatalogs { get; set; }
}
