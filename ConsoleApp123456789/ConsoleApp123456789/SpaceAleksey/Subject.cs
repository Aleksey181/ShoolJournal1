using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp123456789.SpaceAleksey
{
    internal class Subject
    {
        private Guid id;
        public Guid Id { get { return id; } set { id = value; } }
        public Subject(String name)
        { 
            
        }
    }

    internal class Teacher
    {
        public Tuple<Subject, Group>[] SubjGroupCombinations { get; set; }
        private Guid id;
        public Guid Id { get { return id; } set { id = value; } }
        public Teacher(String name)
        {

        }
    }

    internal class Group
    {
        private Guid id;
        public Guid Id { get { return id; } set { id = value; } }
        public Student[] Students { get; set; }
        public Teacher[] Teachers { get; set; }
        public Group(String number)
        {

        }
    }

    internal class Student
    {
        public Group group;
        public Student(String name)
        {

        }
    }

    internal class Marks
    {
        public Marks(List<int> allMarks)
        {

        }
    }
}
