using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;

        public Course(string courseName, string courseCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;

        }
        internal void ShowInfo()
        {

            Console.WriteLine("CourseName: " + courseName);
            Console.WriteLine("CourseCode: " + courseCode);
            Console.WriteLine("CourseCredit: " + courseCredit);

        }
    }
}
