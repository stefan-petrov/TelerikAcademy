using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Class
    {
        private List<Student> setOfStudents;
        private List<Teacher> setOfTeachers;
        private string textIdentifier;

        public Class(string textId)
        {
            this.textIdentifier = textId;
        }

        public void AddStudent(Student student)
        {
            this.setOfStudents.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.setOfStudents.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.setOfTeachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.setOfTeachers.Remove(teacher);
        }

        public Student[] SetOfStudents
        {
            get { return this.setOfStudents.ToArray(); }
            private set;
        }

        public Teacher[] SetOfTeachers
        {
            get { return this.setOfTeachers.ToArray(); }
            private set;
        }
        
    }
}
