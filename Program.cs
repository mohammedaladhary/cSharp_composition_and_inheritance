
namespace compositions_and_inheritans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating students, teachers, and courses
            Student student1 = new Student("Mohammed", 22, "Taamir St", 11234, "G12");
            Student student2 = new Student("Ahmed", 19, "Muscat Seeb", 10202, "G11");
            Console.WriteLine();

            Teacher teacher1 = new Teacher("Salim", 25, "Barka", 21001, new List<string> { "IT", "Physics" });
            Teacher teacher2 = new Teacher("Ammar", 20, "Nakhl", 21002, new List<string> { "Ielts Course" });
            Console.WriteLine();

            Course course1 = new Course(012, "Computer Networks", "basics of the course");
            Course course2 = new Course(022, "Database", "basics and standards");
            Console.WriteLine();

            //students in courses
            course1.enrollStudent(student2);
            course2.enrollStudent(student1);
            Console.WriteLine();

            //teachers to courses
            course1.assignTeacher(teacher2);
            course2.assignTeacher(teacher1);

            // Displaying student, teacher, and course details
            //Console.WriteLine("Student Details:");
            //student1.StudentDetails();
            //Console.WriteLine();
            //student2.StudentDetails();
            //Console.WriteLine();
            //Console.WriteLine();

            Console.WriteLine("Course Details:");
            course1.CourseDetails();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            course2.CourseDetails();
            Console.WriteLine();

            //Console.WriteLine("Teacher Details:");
            //teacher1.TeacherDetails();
            //teacher2.TeacherDetails();
            //Console.WriteLine();
        }
    }
}
