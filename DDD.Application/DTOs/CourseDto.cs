namespace DDD.Application.DTOs;

public class CourseDto
{
	public Guid Id { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public bool IsFree { get; set; }
	public decimal Price { get; set; }
	public Guid InstructorId { get; set; }
}
