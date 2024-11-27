using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class Student
    {
        //fields
        private int Id;
        private string Name;

        //properties
        public int id
        {
            set
            {
                Id = value;
            }
        }
        public string name
        {
            set
            {
                Name = value;
            }
        }

        //constructor
        public Student()
        {
            //default contructor
        }
        //method
        public void displayDetail()
        {
            Console.Write("ID " + Id + " Name " + Name);
        }
        //static method
        public static void Callme()
        {
            Console.Write("hi");
        }
        
    }
}
