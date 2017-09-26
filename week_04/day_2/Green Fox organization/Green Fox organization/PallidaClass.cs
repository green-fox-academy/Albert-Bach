using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_organization
{
    class PallidaClass
    {

        string className;
        List <Student> students  = new List<Student>();
        List <Mentor> mentors = new List<Mentor>();


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
            Console.WriteLine("Pallida"+ className+ "class has"+ students.size + "students" + "and"+ mentors.size + "mentors.");
    }

    }
}
