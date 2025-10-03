using DDD.Infrastructure.EF.Models.PaymentManagement;

namespace DDD.Infrastructure.EF.Models.CourseManagement;

public class CourseReadModel : BaseReadModel
{
    public string Title { get; set; }
    public string description { get; set; }
    public bool IsFree { get; set; }
    public decimal Price { get; set; }
    public Guid InstructureId { get; set; }
	public Guid CourseId { get; set; }

	public InstructorReadModel instructor { get; set; }
    public IReadOnlyList<CoureseAttendeReadModel> CourseAttendees { get; set; }
    public IReadOnlyList<CoureseCatalogReadModel> CourseCatalogs { get; set; }
    public IReadOnlyList<InvoiceReadModel> Invoices { get; set; }
}
