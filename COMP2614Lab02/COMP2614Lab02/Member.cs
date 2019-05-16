using System;

namespace COMP2614Lab02
{
    class Member
    {
        public double ageInDecades;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public double AgeInDecades
        { 
            get{ return Age / 10.0; }
        }  

        public Member(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;            
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}
