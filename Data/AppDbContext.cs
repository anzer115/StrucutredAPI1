using Microsoft.EntityFrameworkCore;

namespace StrucutredAPI1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(k => k.StudentId); 
            modelBuilder.Entity<Course>().HasKey(k => k.C_id); 
            modelBuilder.Entity<StudentCourse>().HasKey(k => new {k.StudentId, k.C_id});

            var students = new List<Student>
{
    new Student { StudentId = 1, Name = "Aarav Sharma", age = 20 },
    new Student { StudentId = 2, Name = "Priya Mehta", age = 21 },
    new Student { StudentId = 3, Name = "Rohan Gupta", age = 19 },
    new Student { StudentId = 4, Name = "Sneha Verma", age = 22 },
    new Student { StudentId = 5, Name = "Arjun Patel", age = 20 }
};
               modelBuilder.Entity<Student>().HasData(
                students
                ); 

                modelBuilder.Entity<Course>().HasData(
                      new Course { C_id = 1, CourseName = "Mathematics" },
                        new Course { C_id = 2, CourseName = "Physics" },
                        new Course { C_id = 3, CourseName = "Computer Science" },
                        new Course { C_id = 4, CourseName = "English Literature" },
                        new Course { C_id = 5, CourseName = "Economics" }
                    );
            modelBuilder.Entity<StudentCourse>().HasData(
    new StudentCourse { StudentId = 1, C_id = 1 },
    new StudentCourse { StudentId = 1, C_id = 3 },
    new StudentCourse { StudentId = 2, C_id = 2 },
    new StudentCourse { StudentId = 3, C_id = 1 },
    new StudentCourse { StudentId = 4, C_id = 4 },
    new StudentCourse { StudentId = 5, C_id = 5 }
);
            modelBuilder.Entity<StudentCourse>()
                .HasOne(x => x.Student)
                .WithMany(y => y.StudentCourses)
                .HasForeignKey(z => z.StudentId); 

            modelBuilder.Entity<StudentCourse>()
                .HasOne(x => x.Course)
                .WithMany(y => y.StudentCourses)
                .HasForeignKey(z => z.C_id);

            modelBuilder.Entity<Student>()
                .HasMany(x => x.StudentCourses)
                .WithOne(y => y.Student)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Course>()
                .HasMany(x => x.StudentCourses)
                .WithOne(y => y.Course)
                .OnDelete(DeleteBehavior.Cascade); 

        }
    }
}
