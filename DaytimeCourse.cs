public class DaytimeCourse : Course
{
    public int SectionNumber { get; set; }
    public string BlockNumber { get; set; }
    public string CertificateID { get; set; }

    public override string CourseType()
    {
        return "Daytime";
    }
}
