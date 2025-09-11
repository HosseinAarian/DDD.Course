using DDD.Domain.Primitives;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities.CourseManagement;

public class Instructor : BaseEntity
{
	private FullName _fullName;
	private Biography _bio;
	private LinkedList<Course> _courses;

	internal Instructor(BaseId id, FullName fullName, Biography bio) : base(id)
	{
		_fullName = fullName;
		_bio = bio;
	}

	public Instructor(BaseId id) : base(id)
	{
		
	}

}
