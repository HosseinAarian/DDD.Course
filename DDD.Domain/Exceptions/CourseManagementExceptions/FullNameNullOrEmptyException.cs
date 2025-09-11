using DDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Exceptions.CourseManagementExceptions;

internal class FullNameNullOrEmptyException : CourseManagementException
{
	public FullNameNullOrEmptyException() : base("Full Name Can Not Be Empty")
	{
	}
}
