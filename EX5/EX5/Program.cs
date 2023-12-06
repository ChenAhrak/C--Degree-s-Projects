using System;

namespace EX5
{
    class Program
    {
        static void Main(string[] args)
        {
            CompulsoryCourse[] compcoursearr = new CompulsoryCourse[Utils.MAX_COURSES];
            string[] students = new string[Utils.MAX_STUDENTS];
            students[0] = "031313361";
            students[1] = "031639142";
            compcoursearr[0] = new CompulsoryCourse("engeneering", Semester.Autumn, "hedva", 1, students, 8);
            ElectiveCourse[] electcoursearr = new ElectiveCourse[Utils.MAX_COURSES];
            string studentId;
            int Courseid;
            while (true)
            {
                try
                {

                    switch (ShowMenu())
                    {
                        case "1":
                            Console.WriteLine("e for Elective or c for compulsuey?");
                            string choose = Console.ReadLine();
                            Course newcourse = AddNewCourse(choose);
                            Console.WriteLine();
                            Console.WriteLine();
                            break;

                        case "2":
                            Console.WriteLine("please enter student ID");
                            studentId = Console.ReadLine();
                            Console.WriteLine("please enter Course ID");
                            Courseid = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter your answer \n 0) Elective \n 1) compulsory");
                            string isComp = Console.ReadLine();
                            if (isComp == "0")
                            {
                                AddStudent(studentId, Courseid, electcoursearr);
                                for (int i = 0; i < electcoursearr.Length; i++)
                                {
                                    if (electcoursearr[i].CourseIdNum == Courseid)
                                    {
                                        // in here were checking if we need to change the course to open
                                        if (electcoursearr[i].MinStudents < electcoursearr[i].MaxStudents - electcoursearr[i].GetFreeSpace())
                                        {
                                            electcoursearr[i].IsOpen = true;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (isComp == "1")
                                {
                                    AddStudent(studentId, Courseid, compcoursearr);
                                }
                                else
                                {
                                    throw new ArgumentException("Please select 0 or 1 to choose course type");
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                            break;
                        case "3":
                            Console.WriteLine("please enter student Id");
                            studentId = Console.ReadLine();
                            string electCourses = getStudentCourses(studentId, electcoursearr);
                            string compulscourse = getStudentCourses(studentId, compcoursearr);
                            Console.WriteLine($"all the course for the student with id number {studentId} \n elective courses: \n { electCourses} \n  compulsory courses:\n {compulscourse}");
                            Console.WriteLine();
                            Console.WriteLine();
                            break;
                        case "4":

                            Console.WriteLine("please enter student Id");
                            studentId = Console.ReadLine();
                            RemoveStudent(studentId, compcoursearr, electcoursearr);
                            Console.WriteLine();
                            Console.WriteLine();
                            break;
                        case "5":
                            Console.WriteLine("please enter student Id");
                            studentId = Console.ReadLine();
                            Console.WriteLine("enter your answer \n 0) Elective \n 1) compulsory");
                            isComp = Console.ReadLine();
                            Console.WriteLine("enter course id number");
                            Courseid = int.Parse(Console.ReadLine());
                            if (isComp == "1")
                            {

                                RemoveStudentCourse(studentId, Courseid, compcoursearr, int.Parse(isComp));
                            }
                            else
                            {
                                RemoveStudentCourse(studentId, Courseid, electcoursearr, int.Parse(isComp));
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                            break;
                        case "6":
                            Console.WriteLine("please enter parameter to show all details");
                            string parameter = Console.ReadLine();
                            string electDetail = getDetailes(parameter, electcoursearr);
                            string compDetail = getDetailes(parameter, compcoursearr);
                            Console.WriteLine($"elective courses details:\n{electDetail}\ncompulsory details:\n{compDetail}");
                            Console.WriteLine();
                            Console.WriteLine();
                            break;
                        case "7":
                            Console.WriteLine($"{ getStudentsCount(electcoursearr)}, { getStudentsCount(compcoursearr)}");
                            Console.WriteLine();
                            Console.WriteLine();
                            break;
                        case "8":
                            Console.WriteLine("***************************");
                            Console.WriteLine(getCoursesCount(compcoursearr, electcoursearr));
                            Console.WriteLine("***************************");
                            Console.WriteLine();
                            Console.WriteLine();
                            break;
                        case "e":
                            Console.WriteLine("Thank you for checking our program! Goodbye now");
                            Environment.Exit(0);
                            break;





                    }


                }


                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            string ShowMenu()
            {
                string choose = "";
                Console.WriteLine("Hello! please choose an option:");
                Console.WriteLine("1) Choosing an Elective Course or Compulsory Course to add");
                Console.WriteLine("2) Add student");
                Console.WriteLine("3) Student Courses List");
                Console.WriteLine("4) Remove a student from the data base");
                Console.WriteLine("5) Remove a student from a course");
                Console.WriteLine("6) Courses details report");
                Console.WriteLine("7) Number of students for each course");
                Console.WriteLine("8) Number of courses for each student");
                Console.WriteLine("e) Exit");
                Console.WriteLine($"Be aware that the maximum students for a course is: {Utils.MAX_STUDENTS}, the maximum courses is: {Utils.MAX_COURSES}");
                Console.Write("Please enter 1 char only: ");

                while (true)
                {
                    choose = Console.ReadLine();
                    switch (choose)
                    {
                        case "1":
                            return choose;
                        case "2":
                            return choose;
                        case "3":
                            return choose;
                        case "4":
                            return choose;
                        case "5":
                            return choose;
                        case "6":
                            return choose;
                        case "7":
                            return choose;
                        case "8":
                            return choose;
                        case "e":
                            return choose;
                        default:
                            Console.WriteLine("Illegal selction, try again");
                            break;

                    }
                }
            }

            //this method is using the choose between Elective and Compulsory course
            //to initialize new course, wer'e setting the number of students that in course to 0
            Course AddNewCourse(string choose)
            {
                Console.WriteLine("Please enter Course name");
                string CourseName = Console.ReadLine();
                Console.WriteLine("Enter Course Id");
                int CourseId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the maximum number of students in this Course");
                int Max_number = int.Parse(Console.ReadLine());
                if (choose == "e")
                {
                    Console.WriteLine("please enter number of facultys that the use the course");
                    int num_facultys = int.Parse(Console.ReadLine());
                    string[] facultys = new string[num_facultys];
                    for (int i = 0; i < num_facultys; i++)
                    {
                        Console.WriteLine($"please enter the {i} faculty");
                        facultys[i] = Console.ReadLine();
                    }
                    Console.WriteLine("enter minimum of students");
                    int min_students = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter academic level \n 0)Low \n 1)Medium \n 2)High ");
                    int academicLvlIndex = int.Parse(Console.ReadLine());
                    ElectiveCourse newCourse = new ElectiveCourse(facultys, (AcademicLevel)academicLvlIndex, min_students, CourseName, CourseId, students, Max_number);
                    return newCourse;
                }
                else
                {
                    Console.WriteLine("enter faculty name:");
                    string faculty_name = Console.ReadLine();
                    Console.WriteLine("please enter the semester: \n 0)Autumn \n 1)Spring \n 2)Summer ");
                    int semesterIndex = int.Parse(Console.ReadLine());
                    CompulsoryCourse NewCompcourse = new CompulsoryCourse(faculty_name, (Semester)semesterIndex, CourseName, CourseId, students, Max_number);
                    return NewCompcourse;

                }
            }

            void AddStudent(string StudentId, int courseId, Course[] parameter)
            {
                bool didtheCourseExist = false;

                for (int i = 0; i < parameter.Length; i++)
                {
                    if (parameter[i] == null)
                    {
                        continue;
                    }
                    if (parameter[i].CourseIdNum == courseId)
                    {
                        parameter[i].AddStudent(StudentId);//in this add student method we check if this if the student exist.
                        didtheCourseExist = true;
                    }

                }
                if (!didtheCourseExist)
                {
                    throw new ArgumentException("the course doesnt exist");
                }
            }
            string getStudentCourses(string idNum, Course[] parameter)
            {
                bool x = false;
                string studentCourses = null;
                for (int i = 0; i < parameter.Length; i++)
                {
                    if (parameter[i] == null)
                    {
                        continue;
                    }
                    for (int j = 0; j < parameter[i].CourseStudents.Length; j++)
                    {
                        if (parameter[i].CourseStudents[j] == null)
                        {
                            continue;
                        }
                        if (parameter[i].CourseStudents[j] == idNum)
                        {
                            x = true;
                            studentCourses += parameter[i].CourseName;
                            studentCourses += ", ";
                        }

                    }
                    if (!x)
                    {
                        throw new ArgumentException("The student doesnt exist in the academy");
                    }
                }
                return studentCourses;
            }

            void RemoveStudent(string idnum, CompulsoryCourse[] comparr, ElectiveCourse[] electarr)
            {
                bool removedElectArr = false;
                bool removedCompArr = false;
                for (int i = 0; i < comparr.Length; i++)
                {
                    if (comparr[i] == null)
                    {
                        continue;
                    }
                    for (int j = 0; j < comparr[i].CourseStudents.Length; j++)
                    {
                        if (idnum == comparr[i].CourseStudents[j])
                        {
                            removedCompArr = true;
                        }
                        if (removedCompArr)
                        {
                            if (j < comparr[i].CourseStudents.Length - 1)
                            {
                                comparr[i].CourseStudents[j] = comparr[i].CourseStudents[j + 1];
                            }
                            else
                            {
                                comparr[i].CourseStudents[j] = null;
                            }
                        }
                    }
                }
                for (int i = 0; i < electarr.Length; i++)
                {
                    if (electarr[i] == null)
                    {
                        continue;
                    }
                    for (int j = 0; j < electarr[i].CourseStudents.Length; j++)
                    {

                        if (idnum == electarr[i].CourseStudents[j])
                        {
                            removedElectArr = true;
                        }
                        if (removedElectArr)
                        {
                            if (j < electarr[i].CourseStudents.Length - 1)
                            {
                                electarr[i].CourseStudents[j] = comparr[i].CourseStudents[j + 1];
                            }
                            else
                            {
                                electarr[i].CourseStudents[j] = null;
                            }
                        }

                    }


                }
                if (!removedElectArr && !removedCompArr)
                {
                    Console.WriteLine("The student doesnt exist");
                }
                else
                {
                    if (removedElectArr || removedCompArr)
                    {
                        Console.WriteLine("The student was removed!");
                    }
                }
            }

            void RemoveStudentCourse(string idstudent, int idCourse, Course[] parameter, int whatCourse)
            {

                bool removed = false;
                for (int i = 0; i < parameter.Length; i++)
                {
                    if (parameter[i] == null)
                    {
                        continue;
                    }
                    if (idCourse == parameter[i].CourseIdNum)
                    {
                        parameter[i].RemoveStudent(idstudent);
                        removed = true;
                        if (whatCourse == 0)
                        {
                            if (parameter[i].MaxStudents - parameter[i].GetFreeSpace() < ((ElectiveCourse)parameter[i]).MinStudents)
                            {
                                ((ElectiveCourse)parameter[i]).IsOpen = false;
                            }
                        }
                        if (removed)
                        {
                            for (int j = i; j < parameter[i].CourseStudents.Length; j++)
                            {
                                if (j < parameter[i].CourseStudents.Length - 1)
                                {
                                    parameter[i].CourseStudents[j] = parameter[i].CourseStudents[j + 1];
                                }
                                else
                                {
                                    parameter[i].CourseStudents[j] = null;
                                }
                            }
                        }

                    }
                }
                if (!removed)
                {
                    throw new Exception("the course doesnt exist");

                }
                else
                {
                    Console.WriteLine("The student was removed!");
                }

            }
            string getDetailes(string parameter, Course[] CourseParameter)
            {

                string coursesDetails = "";
                for (int i = 0; i < CourseParameter.Length; i++)
                {
                    if (CourseParameter[i] == null)
                    {
                        continue;
                    }
                    coursesDetails += CourseParameter[i].getDetails(parameter);
                }
                return coursesDetails;
            }
            string getStudentsCount(Course[] parameter)
            {
                string studentsCount = "";
                for (int i = 0; i < parameter.Length; i++)
                {

                    if (parameter[i] != null)
                    {
                        studentsCount += '\n';
                        studentsCount += $"{parameter[i].CourseName}  {(parameter[i].MaxStudents) - (parameter[i].GetFreeSpace())}";
                    }
                }
                return studentsCount;
            }
            string getCoursesCount(Course[] comp, Course[] elect)
            {
                string stringToReeturn = "";
                int indexID = 0;
                string[] uniqueId = new string[2 * Utils.MAX_COURSES * Utils.MAX_STUDENTS];
                indexID = InsertingUniqueID(indexID, comp, uniqueId);
                indexID = InsertingUniqueID(indexID, elect, uniqueId);
                int[] numOfCoursesPerStudent = new int[2 * Utils.MAX_COURSES * Utils.MAX_STUDENTS];
                countingNumOfCoursesPerStudent(uniqueId, comp, numOfCoursesPerStudent);
                countingNumOfCoursesPerStudent(uniqueId, elect, numOfCoursesPerStudent);
                for (int i = 0; i < uniqueId.Length; i++)
                {
                    if (uniqueId[i] == null)
                    {
                        continue;
                    }
                    stringToReeturn += $"Student: {uniqueId[i]}, Number of courses: {numOfCoursesPerStudent[i]}\n";
                }
                return stringToReeturn;
            }

            int InsertingUniqueID(int index, Course[] courseArray, string[] uniqueId)
            {
                for (int i = 0; i < Utils.MAX_COURSES; i++)
                {
                    if (courseArray[i] == null)
                    {
                        continue;
                    }
                    for (int j = 0; j < Utils.MAX_STUDENTS; j++)
                    {
                        if (courseArray[i].CourseStudents[j] == null)
                        {
                            continue;
                        }
                        else
                        {
                            if (IsExist(uniqueId, courseArray[i].CourseStudents[j]))//Chceks if a certain ID is in the array.
                            {
                                continue;
                            }
                            else
                            {
                                uniqueId[index] = courseArray[i].CourseStudents[j];
                                index++;
                            }
                        }

                    }
                }
                return index;
            }

            bool IsExist(string[] idArr, string idParameter)//Chceks if a certain ID is in the array.
            {
                for (int i = 0; i < idArr.Length; i++)
                {
                    if (idArr[i] == idParameter)
                    {
                        return true;
                    }
                }
                return false;
            }

            void countingNumOfCoursesPerStudent(string[] uniqueID, Course[] courseArray, int[] numOfCoursesPerStudent)
            {
                for (int i = 0; i < courseArray.Length; i++)
                {
                    if (courseArray[i] == null)
                    {
                        continue;
                    }
                    for (int j = 0; j < courseArray[i].CourseStudents.Length; j++)
                    {
                        if (courseArray[i].CourseStudents[j] == null)
                        {
                            continue;
                        }
                        for (int k = 0; k < uniqueID.Length; k++)
                        {
                            if (uniqueID[k] == courseArray[i].CourseStudents[j])
                            {
                                numOfCoursesPerStudent[k]++;
                            }
                        }

                    }
                }

            }
        }


    }
}