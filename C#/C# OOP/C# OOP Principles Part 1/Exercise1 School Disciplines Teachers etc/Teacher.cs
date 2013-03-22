using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Teacher : People
    {
        private List<Discipline> setOfDisciplines;

        public Teacher(string name)
        {
            this.Name = name;
        }
        
        public void AddDiscipline(Discipline disc)
        {
            this.setOfDisciplines.Add(disc);
        }

        public void RemoveDiscipline(Discipline disc)
        {
            this.setOfDisciplines.Remove(disc);
        }



    }
}
