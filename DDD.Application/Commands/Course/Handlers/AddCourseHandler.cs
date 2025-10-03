using DDD.Domain.Factories.CourseManagement;
using DDD.Domain.Repositories.CourseManagement;
using DDD.Shared.Abstraction.Commands;

namespace DDD.Application.Commands.Course.Handlers;

public class AddCourseHandler(ICourseRepository repository, ICourseFactory factory) : ICommandHandler<AddCourse>
{
    public async Task HandleAsync(AddCourse command)
    {
        var course = factory.Create(command.id, command.title, command.description, command.isFree, command.price, command.instructorId);
        await repository.AddAsync(course);
    }
}
