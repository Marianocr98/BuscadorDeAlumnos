using System.Collections.Generic;

namespace BuscadorDeAlumnos
{
    public class SearchStudentBy
    {
        /// <summary>
        /// Search for a student by name.
        /// </summary>
        /// <param name="students"></param>
        /// <param name="name"></param>
        /// <returns>Student List</returns>
        public static List<Student> Name(List<Student> students, string name)
        {
            List<Student> filteredStudents = new List<Student>();
            foreach (Student student in students)
            {
                if (student.GetName() == name)
                    filteredStudents.Add(student);
            }
            return filteredStudents;
        }

        /// <summary>
        /// Search for a student by ID.
        /// </summary>
        /// <param name="students"></param>
        /// <param name="id"></param>
        /// <returns>Student</returns>
        public static Student Id(List<Student> students, int id)
        {
            Student studentFoundById = new Student();
            foreach (Student student in students)
            {
                if (student.GetId() == id)
                {
                    studentFoundById = student;
                }
            }
            return studentFoundById;
        }

        /// <summary>
        /// Search for a student for their Non-Active.
        /// </summary>
        /// <param name="students"></param>
        /// <returns>Student List</returns>
        public static List<Student> NotActive(List<Student> students)
        {
            List<Student> filteredStudents = new List<Student>();
            foreach (var student in students)
            {
                if (student.GetActive() == false)
                    filteredStudents.Add(student);
            }
            return filteredStudents;
        }

        /// <summary>
        /// Search for a student by their Average Greater than 7.
        /// </summary>
        /// <param name="students"></param>
        /// <returns>Student</returns>
        public static Student AverageGreaterThan7(List<Student> students)
        {
            Student averageGreaterThan7 = new Student();
            foreach (var student in students)
            {
                if (student.GetAverage() > 7)
                    averageGreaterThan7 = student;
            }
            return averageGreaterThan7;
        }

        /// <summary>
        /// Find one student per Classroom.
        /// </summary>
        /// <param name="students"></param>
        /// <param name="classroom"></param>
        /// <returns>Student List</returns>
        public static List<Student> Classroom(List<Student> students, string classroom)
        {
            List<Student> studentsFilteredByClassroom = new List<Student>();
            foreach (var student in students)
            {
                if (student.GetClassroom() == classroom)
                    studentsFilteredByClassroom.Add(student);
            }
            return studentsFilteredByClassroom;
        }
    }
}
