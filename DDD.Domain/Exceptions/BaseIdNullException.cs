using DDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Exceptions;

internal class BaseIdNullException : CourseManagementException
{
	public BaseIdNullException() : base("Id Can Not Be Empty")
	{
	}
}
