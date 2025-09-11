using DDD.Domain.Entities.CourseManagement;
using DDD.Domain.Entities.UserManagement;
using DDD.Domain.Primitives;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities.PaymentManagement;

public class Invoice : BaseEntity
{
	private Amount _amount;
	private DateTime _date;
	private BaseId _userId;
	private BaseId _courseId;

	internal Invoice(BaseId id, Amount amount, DateTime date, BaseId userId, BaseId courseId) : base(id)
	{
		_amount = amount;
		_date = date;
		_userId = userId;
		_courseId = courseId;
	}

	public Invoice(BaseId id) : base(id)
	{
		
	}
}
