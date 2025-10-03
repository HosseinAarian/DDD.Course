namespace DDD.Infrastructure.EF.Models.UserManagement;

public class UserRoleReadModel : UserReadModel
{
	public Guid UserId { get; set; }
	public Guid RoleId { get; set; }
	public RoleReadModel Role { get; set; }
    public UserReadModel User { get; set; }
}
