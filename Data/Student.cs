namespace StrucutredAPI1.Data
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int age { get; set;  }

        public ICollection<StudentCourse> StudentCourses = new List<StudentCourse>(); 

    }
}
