using System;
using System.Collections.Generic;
using System.Text;

namespace EX5
{
     class Course
    {
        string courseName;
        int courseIdNum;
        string[] courseStudents = new string[Utils.MAX_STUDENTS];
        int maxStudents;

        public Course(string courseName, int courseIdNum, string[] courseStudents, int maxStudents)
        {
            CourseName = courseName;
            CourseIdNum = courseIdNum;
            this.courseStudents = courseStudents;
            this.maxStudents = maxStudents;

        }

        public string CourseName
        {
            get => courseName;
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                if (value == "")
                    throw new ArgumentException("Error: Empty Course Name!!");

                courseName = value;
            }
        }
        public int CourseIdNum
        {
            get => courseIdNum;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Error: course id number negative");
                courseIdNum = value;
            }
        }


        public string[] CourseStudents { get => courseStudents; }
        public int MaxStudents { get => maxStudents; }

        public void AddStudent(string id)
        {
            Utils.checkidNumber(id);
            if (courseStudents[courseStudents.Length - 1] != null)
                throw new InvalidOperationException("The courese is full!!");
            int i = 0;
            while(courseStudents[i]!=null)
            {
                i++;
            }
            courseStudents[i] = id;

        }

        public void RemoveStudent(string id)
        {
            Utils.checkidNumber(id);
            bool flag = false;
            int index = 0;
            for (int i = 0; i < courseStudents.Length; i++)
            {
                if (courseStudents[i] == id)
                {
                    flag = true;
                    index = i;
                }

            }

            if (flag == false)
                throw new InvalidOperationException("Unregistered!!");
            while(index<courseStudents.Length-1)
            {
                if (courseStudents[index] == null)
                {
                    courseStudents[index - 1] = courseStudents[index];
                    break;
                }
               courseStudents[index] = courseStudents[index + 1];
               index++;
            }
            courseStudents[index] = null;
        }

        public int GetFreeSpace()
        {
            for (int i = 0; i < this.courseStudents.Length; i++)
            {
                if (courseStudents[i] == null)
                {
                    return this.maxStudents - i;
                }
            }
            return this.courseStudents.Length;
        }
        public virtual string getDetails(string parameter)
        {
            string Details = $"Course:{this.courseName}, number of students: {this.GetFreeSpace()}, number of free space in course: {this.maxStudents - this.GetFreeSpace()}\n";
            for (int i = 0; i < this.GetFreeSpace(); i++)
            {
                if (courseStudents[i] == null)
                {
                    continue;
                }
                Details += this.courseStudents[i];
                Details += parameter;
            }
            return Details += parameter;
        }
    }
}
