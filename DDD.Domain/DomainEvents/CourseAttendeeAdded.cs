using DDD.Domain.Entities.CourseManagement;
using DDD.Shared.Abstraction.Domain;

namespace DDD.Domain.DomainEvents;

public record CourseAttendeeAdded(Course course, CourseAttende attende) : IDomainEvent;

