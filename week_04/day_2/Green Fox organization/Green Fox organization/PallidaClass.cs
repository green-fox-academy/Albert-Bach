using System;
using System.Collections.Generic;

namespace Green_Fox_organization
{
    class PallidaClass
    {
        private string className;
        private List<Student> students;
        private List<Mentor> mentors;

        public PallidaClass(string className)
        {
            this.className = className;
            this.students = new List<Student>();
            this.mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine("Pallida {0} class has {1} students and {2} mentors.", this.className,
                           this.students.Count, this.mentors.Count);
        }
    }
}
