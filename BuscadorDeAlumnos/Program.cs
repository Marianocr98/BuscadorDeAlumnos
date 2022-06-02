using System;
using System.Collections.Generic;

namespace BuscadorDeAlumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            Student alumno1 = new Student("Camila", 1, new List<double> { 1, 2, 3, 3, 5, 5 }, "Sala01");
            Student alumno2 = new Student("Camila", 2, new List<double> { 3, 2, 5, 4, 7, 6 }, "Sala01");
            Student alumno3 = new Student("Camila", 3, new List<double> { 0, 6, 3, 8, 5, 2 }, "Sala02");
            Student alumno4 = new Student("Cami", 4, new List<double> { 10, 8, 9, 9.99, 8, 7.80 }, "Sala03");

            List<Student> students = new List<Student> { alumno1, alumno2, alumno3, alumno4 };

            ShowAListOfStudents(SearchStudentBy.Name(students, "Camila"));
            ShowAStudent(SearchStudentBy.AverageGreaterThan7(students));
            ShowAListOfStudents(SearchStudentBy.Classroom(students, "Sala01"));

        }

        #region ShowAListOfStudents
        /// <summary>
        /// Displays a Student List by console.
        /// </summary>
        /// <param name="students"></param>
        public static void ShowAListOfStudents(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No se encontraron resultados \n");
            }
            else
            {
                Console.WriteLine($"id\t Name\t active\t classroom\t average");
                foreach (Student item in students)
                {
                    Console.WriteLine($"{item.GetId()}\t {item.GetName()}\t {item.GetActive()}\t {item.GetClassroom()}\t {item.GetAverage()}\n");
                }
            }
        }
        #endregion
        #region ShowAStudent
        /// <summary>
        /// Shows the student by console.
        /// </summary>
        /// <param name="student"></param>
        public static void ShowAStudent(Student student)
        {
            Console.WriteLine($"{student.GetId()}\t {student.GetName()}\t {student.GetActive()}\t {student.GetClassroom()}\t {student.GetAverage()}\n");
        }
        #endregion
    }
}
