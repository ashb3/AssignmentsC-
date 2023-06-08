DaytimeCourse daytimeCourse = new DaytimeCourse()
{
    Name = "Economics101",
    CourseCode = "CMSK0550",
    Description = "Learn the basics of Economics",
    InstructorName = "Arnold Shoemaker",
    NumberOfStudents = 25,
    SectionNumber = 1000909,
    BlockNumber = "A1",
    CertificateID = "PP800-Y289"
};

EveningCourse eveningCourse = new EveningCourse()
{
    Name = "Philosophy Of Aristotle",
    CourseCode = "CMSK0950",
    Description = "Collection",
    InstructorName = "Corey Chase",
    NumberOfStudents = 10,
    ContractorID = "CVEN-9002",
    ContractEndDate = DateTime.Now.AddDays(30)
};

Console.WriteLine(daytimeCourse.CourseType());  // Output: Daytime
Console.WriteLine(eveningCourse.CourseType());  // Output: Evening
