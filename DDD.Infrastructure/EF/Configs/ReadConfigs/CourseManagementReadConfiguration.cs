using DDD.Infrastructure.EF.Models.CourseManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDD.Infrastructure.EF.Configs.ReadConfigs;

internal sealed partial class ReadConfigurations : IEntityTypeConfiguration<CourseReadModel>,
                                                   IEntityTypeConfiguration<CoureseCatalogReadModel>,
                                                   IEntityTypeConfiguration<CoureseAttendeReadModel>,
                                                   IEntityTypeConfiguration<LessonReadModel>,
                                                   IEntityTypeConfiguration<InstructorReadModel>
{
    public void Configure(EntityTypeBuilder<CourseReadModel> builder)
    {
        builder.ToTable("Courses");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Title);
        builder.Property(c => c.description);
        builder.Property(c => c.IsFree);
        builder.Property(c => c.Price);
        builder.Property(c => c.InstructureId);

        builder.HasOne(c => c.instructor)
            .WithMany(i => i.Courses)
            .HasForeignKey(c => c.InstructureId);

        builder.HasMany(c => c.CourseAttendees)
            .WithOne(ca => ca.Course)
            .HasForeignKey(ca => ca.CourseId);

        builder.HasMany(c => c.CourseCatalogs)
            .WithOne(cc => cc.Course)
            .HasForeignKey(cc => cc.CourseId);
    }

    public void Configure(EntityTypeBuilder<CoureseCatalogReadModel> builder)
    {
        builder.ToTable("CourseCatalogs");
        builder.HasKey(cc => cc.Id);
        builder.Property(cc => cc.Title).IsRequired();
        builder.Property(cc => cc.Description).IsRequired();
        builder.Property(cc => cc.CourseId);

        builder.HasOne(cc => cc.Course)
            .WithMany(c => c.CourseCatalogs)
            .HasForeignKey(cc => cc.CourseId);

        builder.HasMany(cc => cc.Lessons)
            .WithOne(l => l.CourseCatalog)
            .HasForeignKey(l => l.catalogId);
    }

    public void Configure(EntityTypeBuilder<CoureseAttendeReadModel> builder)
    {
        builder.ToTable("CoureseAttendes");
        builder.HasKey(ca => ca.Id);
        builder.Property(ca => ca.UserId);

        builder.HasOne(ca => ca.User)
            .WithMany(u => u.CoureseAttendes)
            .HasForeignKey(ca => ca.UserId);

        builder.HasOne(ca => ca.Course)
            .WithMany(c => c.CourseAttendees)
            .HasForeignKey(ca => ca.CourseId);
    }

    public void Configure(EntityTypeBuilder<LessonReadModel> builder)
    {
        builder.ToTable("Lessons");
        builder.HasKey(l => l.Id);
        builder.Property(l => l.Title).IsRequired();
        builder.Property(l => l.VideoUrl);
        builder.Property(l => l.catalogId);
        builder.HasOne(l => l.CourseCatalog)
            .WithMany(cc => cc.Lessons)
            .HasForeignKey(l => l.catalogId);
    }

    public void Configure(EntityTypeBuilder<InstructorReadModel> builder)
    {
        builder.ToTable("Instructor");
        builder.HasKey(i => i.Id);
        builder.Property(i => i.FullName);
        builder.Property(i => i.Bio);
        builder.Property(i => i.rating);
        builder.Property(i => i.Exprience);

        builder.HasMany(i => i.Courses)
            .WithOne(c => c.instructor)
            .HasForeignKey(c => c.InstructureId);
    }
}
