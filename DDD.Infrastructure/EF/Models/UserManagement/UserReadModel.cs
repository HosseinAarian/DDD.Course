using DDD.Infrastructure.EF.Models.CourseManagement;
using DDD.Infrastructure.EF.Models.PaymentManagement;

namespace DDD.Infrastructure.EF.Models.UserManagement;

public class UserReadModel : BaseReadModel
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public bool Confirmed { get; set; }

    public IReadOnlyList<CoureseAttendeReadModel> CoureseAttendes { get; set; }
	public IReadOnlyList<UserRoleReadModel> UserRoles { get; set; }
    public IReadOnlyList<InvoiceReadModel> Invoices { get; set; }
}
