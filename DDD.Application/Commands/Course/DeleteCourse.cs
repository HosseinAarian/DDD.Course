using DDD.Domain.ValueObjects;
using DDD.Shared.Abstraction.Commands;

namespace DDD.Application.Commands.Course;

public record DeleteCourse(BaseId id) : ICommand;

