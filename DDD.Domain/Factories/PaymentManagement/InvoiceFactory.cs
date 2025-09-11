using DDD.Domain.Entities.PaymentManagement;
using DDD.Domain.ValueObjects;

namespace DDD.Domain.Factories.PaymentManagement;

public class InvoiceFactory : IInvoiceFactory
{
	public Invoice Create(BaseId id, Amount amount, DateTime date, BaseId userId, BaseId courseId)
	{
		return new Invoice(id, amount, date, userId, courseId);
	}
}
