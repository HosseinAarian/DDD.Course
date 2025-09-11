using DDD.Domain.Primitives;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities.CourseManagement;

public class CourseAttende : BaseEntity
{
	private BaseId _courseId;
	private BaseId _userId;

	internal CourseAttende(BaseId id, BaseId courseId, BaseId userId) : base(id)
	{
		_courseId = courseId;
		_userId = userId;
	}

	public CourseAttende(BaseId id) : base(id)
	{
		
	}

}
