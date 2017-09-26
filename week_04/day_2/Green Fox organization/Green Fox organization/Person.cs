using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_organization
{
    class Person
    {
            
        public string name;
        public int age;
        public string gender;

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm" + name + age + "year old" + gender);
        }
        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }

        public Person()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
        }
      
    }
}
