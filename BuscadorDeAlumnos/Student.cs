using System.Collections.Generic;
using System.Linq;

namespace BuscadorDeAlumnos
{
    public class Student
    {
        private string name;
        private int id;
        private bool active;
        private List<double> notes;
        private double average;
        private string classroom;

        public Student()
        {

        }

        public Student(string name, int id, List<double> notes, string classroom)
        {
            this.name = name;
            this.id = id;
            this.active = true;
            this.notes = notes;
            this.average = notes.Average();
            this.classroom = classroom;
        }

        public string GetName()
        {
            return name;
        }
        public int GetId()
        {
            return id;
        }
        public bool GetActive()
        {
            return active;
        }
        public List<double> GetNotes()
        {
            return notes;
        }

        public double GetAverage()
        {
            return average;
        }

        public string GetClassroom()
        {
            return classroom;
        }
    }
}
