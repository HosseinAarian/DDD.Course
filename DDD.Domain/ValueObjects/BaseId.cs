using DDD.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects;

public record BaseId
{
	public Guid Value { get;}

	public BaseId(Guid value)
	{
		if (value == Guid.Empty)
		{
			throw new BaseIdNullException();
		}
		Value = value;
	}

	public static implicit operator Guid(BaseId id)=> id.Value;
	public static implicit operator BaseId(Guid id) => new (id);

}
