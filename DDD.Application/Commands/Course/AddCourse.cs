using DDD.Domain.ValueObjects;
using DDD.Shared.Abstraction.Commands;

namespace DDD.Application.Commands.Course;

public record AddCourse(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId) : ICommand;

