using DDD.Domain.ValueObjects;

namespace DDD.Domain.Primitives;

public abstract class BaseEntity
{
	public BaseId Id { get; private set; }

	protected BaseEntity(BaseId id)
	{
		Id = id;
	}
}
