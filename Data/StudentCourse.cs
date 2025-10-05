namespace StrucutredAPI1.Data
{
    public class StudentCourse
    {
        public int StudentId { get; set; }
        public int C_id { get; set;  }

        public Student Student { get; set; }
        public Course Course { get; set; }

    }
}
