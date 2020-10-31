using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class Student
    {
        //fields
        private string name;
       private string id;
        private string department;
        private float cgpa;
       

        
        public Student(string name, string id,string department, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
          
        }
        internal void ShowInfo()
        {

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Cgpa:"  + cgpa);
        }
    }
}

    