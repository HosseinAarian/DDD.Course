using DDD.Infrastructure.EF.Models.PaymentManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDD.Infrastructure.EF.Configs.ReadConfigs;

internal sealed partial class ReadConfigurations : IEntityTypeConfiguration<InvoiceReadModel>
{
	public void Configure(EntityTypeBuilder<InvoiceReadModel> builder)
	{
		builder.ToTable("Invoice");
		builder.HasKey(i => i.Id);
		builder.Property(i => i.Amount);
		builder.Property(i => i.Date);
		builder.Property(i => i.UserId);
		builder.Property(i => i.CourseId);

		builder.HasOne(i => i.User)
			.WithMany(u => u.Invoices)
			.HasForeignKey(i => i.UserId);

		builder.HasOne(i => i.Course)
			.WithMany(c => c.Invoices)
			.HasForeignKey(i => i.CourseId);

    }
}
