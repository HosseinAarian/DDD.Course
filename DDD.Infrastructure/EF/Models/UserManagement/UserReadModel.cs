namespace DDD.Infrastructure.EF.Models.UserManagement;

public class UserReadModel
{
	public Guid Id { get; set; }
	public string UserName { get; set; }
	public string Password { get; set; }
	public string Email { get; set; }
	public bool Confirmed { get; set; }
}
