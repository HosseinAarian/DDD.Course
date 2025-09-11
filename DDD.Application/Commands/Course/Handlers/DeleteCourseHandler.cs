using DDD.Application.Exceptions;
using DDD.Domain.Factories.CourseManagement;
using DDD.Domain.Repositories.CourseManagement;
using DDD.Shared.Abstraction.Commands;

namespace DDD.Application.Commands.Course.Handlers;

public class DeleteCourseHandler : ICommandHandler<DeleteCourse>
{
	private readonly ICourseRepository repository;

	public DeleteCourseHandler(ICourseRepository repository)
	{
		this.repository = repository;
	}
	public async Task HandleAsync(DeleteCourse command)
	{
		var course = await repository.GetAsync(command.id);
		if (course is null)
		{
			throw new CourseNotFoundException();
		}

		await repository.DeleteAsync(course);
	}
}
