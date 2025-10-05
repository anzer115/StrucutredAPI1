namespace StrucutredAPI1.Data
{
    public class Course
    {
        public int C_id { get; set;  }
        public string CourseName { get; set; }

        public ICollection<StudentCourse> StudentCourses = new List<StudentCourse>();
    }
}
