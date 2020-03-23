using System;
using System.Collections.Generic;
using System.Text;

namespace School
{

    public class student
    {

        private static int nextStudentId = 1; // Use to auto-increment StudentIds
        public string Name { get; private set; } //Name will be readable by everyone, but modifiable only by code within the class' assembly.
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public student(string name, int numberOfCredits,
        double gpa)
        {
            StudentId = nextStudentId++;
            Name = name;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public student(string name)
        : this(name, 0, 0) { }

        public override string ToString()
        {
            return "Name: " + Name + "\nID: " + StudentId
                + "\nNumber of Credits: " + NumberOfCredits
                + "\nGPA: " + Gpa;
        }

    }
}