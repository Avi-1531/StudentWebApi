namespace Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }

       public List<Course> Courses { get; set; }
        public Department()
        {
            Courses = new List<Course>();
        }
    }
}
