using System;
using System.Collections.Generic;
using System.Text;

namespace EX5
{
    public enum Semester { Autumn, Spring, Summer };
    class CompulsoryCourse : Course
    {
       
        Semester s;
        string faculty;

        public Semester S
        {
            get => s;
            set => s=value;
        }

        public string Faculty
        {
            get => faculty;
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                if (value == "")
                    throw new ArgumentException("Error: Empty faculty Name!!");
                if (value.Length > 32)
                    throw new ArgumentException("Error:Overflow!!!");
                faculty = value;
            }
        }


        public CompulsoryCourse(string faculty, Semester s,string courseName, int courseIdNum, string[] courseStudents, int maxStudents) : base(courseName, courseIdNum, courseStudents, maxStudents)
        {
            Faculty = faculty;
            this.s = s;
        }

        public override string getDetails(string tav)
        {
            return $"{ base.getDetails(tav)} Faculty:  faculty  {tav} Semester:  {s}";

        }

    }
}
