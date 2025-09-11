using DDD.Domain.Entities.PaymentManagement;
using DDD.Domain.ValueObjects;

namespace DDD.Domain.Factories.PaymentManagement;

public interface IInvoiceFactory
{
	Invoice Create(BaseId id, Amount amount, DateTime date, BaseId userId, BaseId courseId);
}
