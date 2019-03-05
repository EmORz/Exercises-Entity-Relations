using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;

namespace P01_StudentSystem.Data.EntityConfiguration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Course> builder)
        {
            //o Name(up to 80 characters, unicode)
            //o Description(unicode, not required)

            builder.Property(x => x.Name)
                .HasMaxLength(80)
                .IsUnicode()
                .IsRequired();
            builder.Property(x => x.Description)
                .IsRequired(false)
                .IsUnicode();

                //•	One course can have many StudentsEnrolled
                //•	One course can have many Resources
                //•	One course can have many HomeworkSubmissions

            builder.HasMany(x => x.StudentsEnrolled)
                .WithOne(x => x.Course)
                .HasForeignKey(x => x.CourseId);

            builder.HasMany(x => x.Resources)
                .WithOne(x => x.Course)
                .HasForeignKey(x => x.CourseId);

            builder.HasMany(x => x.HomeworkSubmissions)
                .WithOne(x => x.Course)
                .HasForeignKey(x => x.CourseId);


        }
    }
}