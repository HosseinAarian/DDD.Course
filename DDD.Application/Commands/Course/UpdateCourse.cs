using DDD.Domain.ValueObjects;
using DDD.Shared.Abstraction.Commands;

namespace DDD.Application.Commands.Course;

public record UpdateCourse(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId) : ICommand;

