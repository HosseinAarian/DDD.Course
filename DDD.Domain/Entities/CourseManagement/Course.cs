using DDD.Domain.DomainEvents;
using DDD.Domain.Primitives;
using DDD.Domain.ValueObjects;
using DDD.Shared.Abstraction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities.CourseManagement;

public class Course : AggregateRoot<BaseId>
{
	private Title _title;
	private Description _description;
	private bool _isFree;
	private Price _price;
	private BaseId _instructorId;

	private LinkedList<CourseAttende> _courseAttendes;
	private LinkedList<CourseCatalog> _courseCatalogs;

	internal Course(BaseId id, Title title, Description description, bool isFree, Price price, BaseId instructorId)
	{
		Id = id;
		_title = title;
		_description = description;
		_isFree = isFree;
		_price = price;
		_instructorId = instructorId;
		RaiseDomainEvent(new NewCourseCreated(this));
	}

	public Course()
	{
		
	}
}
