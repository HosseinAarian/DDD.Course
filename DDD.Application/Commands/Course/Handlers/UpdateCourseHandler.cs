using DDD.Application.Exceptions;
using DDD.Domain.Factories.CourseManagement;
using DDD.Domain.Repositories.CourseManagement;
using DDD.Shared.Abstraction.Commands;

namespace DDD.Application.Commands.Course.Handlers;

public class UpdateCourseHandler(ICourseRepository repository, ICourseFactory factory) : ICommandHandler<UpdateCourse>
{
    public async Task HandleAsync(UpdateCourse command)
    {
        var course = await repository.GetAsync(command.id);
        if (course == null)
        {
            throw new CourseNotFoundException();
        }

        course = factory.Create(course.Id, command.title, command.description, command.isFree, command.price, command.instructorId);
    }
}
