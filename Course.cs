using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compositions_and_inheritans
{
    internal class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int teacherID { get; set; }
        public Student Student { get; set; }

        public Course(int courseID, string title, string description)
        {
            CourseID = courseID;
            Title = title;
            Description = description;
        }

        public void CourseDetails()
        {
            Console.WriteLine("Course ID :" + CourseID);
            Console.WriteLine("Title :" + Title);
            Console.WriteLine("Description :" + Description);
            Console.WriteLine("Teacher ID :" + teacherID);
        }

        public void assignTeacher(Teacher teacherID)
        {
            Console.WriteLine("Teacher ID: " + teacherID);
        }
        public void enrollStudent(Student student)
        {
            Student = student;
        }
    }
}
