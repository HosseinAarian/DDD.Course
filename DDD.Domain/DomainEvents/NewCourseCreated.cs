using DDD.Domain.Entities.CourseManagement;
using DDD.Shared.Abstraction.Domain;

namespace DDD.Domain.DomainEvents;

public record NewCourseCreated(Course course) : IDomainEvent;

