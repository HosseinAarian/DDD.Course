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
	private double _rating;
	private int _exprience;
	private LinkedList<Course> _courses;

	internal Instructor(BaseId id, FullName fullName, Biography bio) : base(id)
	{
		_fullName = fullName;
		_bio = bio;
		_exprience = 3;
		_rating = 0;
	}

	internal Instructor(BaseId id, FullName fullName, Biography bio, int exprience) : base(id)
	{
		_fullName = fullName;
		_bio = bio;
		_exprience = exprience;
		_rating = 0;
	}

	internal Instructor(BaseId id, FullName fullName, Biography bio, int exprience, double rating) : base(id)
	{
		_fullName = fullName;
		_bio = bio;
		_exprience = exprience;
		_rating = rating;
	}

	public Instructor(BaseId id) : base(id)
	{
		
	}

}
