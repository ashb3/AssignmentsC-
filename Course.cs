public class Course
{
    public string Name { get; set; }
    public string CourseCode { get; set; }
    public string Description { get; set; }
    public string InstructorName { get; set; }
    public int NumberOfStudents { get; set; }

    public virtual string CourseType()
    {
        return "Base Course";
    }
}
