using System;
using System.Collections.Generic;
using System.Text;

namespace EX5
{
    public enum AcademicLevel { Low, Medium, High };
    class ElectiveCourse : Course
    {
        string[] FacultyArrray = new string[3];
        
        AcademicLevel a;
        int minStudents;
        bool isOpen;

        public string[] FacultyArrray1
        {
            get => FacultyArrray;
            set
            {
                for (int i = 0; i < 3; i++)
                {
                    if (value[i] == "")
                        throw new ArgumentException("Error: Empty faculty Name!!");
                    if (value[i].Length > 32)
                        throw new ArgumentException("Error:Overflow!!!");
                }
                FacultyArrray = value;
            }
        }

        public AcademicLevel A
        {
            get => a;
            set => a=value;
        }

        public int MinStudents
        {
            get => minStudents;
            set
            {
                if (value < 0 && value >= base.MaxStudents)
                    throw new ArgumentException("Not valid!!");
                minStudents = value;
            }
        }
        public bool IsOpen { get => isOpen; set => isOpen = value; }

       

        public ElectiveCourse(string[] facultyArrray,AcademicLevel a, int minStudents, string courseName, int courseIdNum, string[] courseStudents, int maxStudents) : base(courseName, courseIdNum, courseStudents, maxStudents)
        {
            FacultyArrray1 = facultyArrray;
            this.a = a;
            this.MinStudents = minStudents;
            this.IsOpen = isOpen;

        }

        public override string getDetails(string tav)
        {
            string listOfFaculties = "";
            foreach (string str in FacultyArrray)
            {
                listOfFaculties = listOfFaculties + tav + str;
            }
            return $"{base.getDetails(tav)} List of faculies: {listOfFaculties} Academic Laevel: {a}{tav}" +
                $"Minimum Students: {minStudents}{tav} Maximum Students: {base.MaxStudents}{tav} Status of course: {isOpen}"; 
        }

        public bool Open()
        {
            if (isOpen == true && base.CourseStudents.Length < base.MaxStudents)
                return true;
            return false;

        }

        public bool Close()
        {
            if (isOpen == false)
                throw new InvalidOperationException("Error: The course is close!!");
            if (base.CourseStudents.Length < minStudents)
            {
                isOpen = false;
                return true;
            }
            return false ;
        }
    }
}
