using System;
using System.Collections.Generic;

namespace Cloneable
{
	class Student : ICloneable
	{
		string name;
		int age;
		string gender;
		string previousOrganization;

		public Student(string name, int age, string gender, string previousOrganization)
		{
			this.name = name;
			this.age = age;
			this.gender = gender;
			this.previousOrganization = previousOrganization;
		}

		public void Introduce()
		{
			Console.WriteLine("{0} {1} {2} {3}", name, age, gender, previousOrganization);
		}

		public object Clone()
		{
			return MemberwiseClone();
		}

	}
}