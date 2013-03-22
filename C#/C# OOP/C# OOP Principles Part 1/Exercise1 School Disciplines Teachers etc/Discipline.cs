using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Discipline
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numberLectures, int numberExercises)
        {
            this.name = name;
            this.numberOfLectures = numberLectures;
            this.numberOfExercises = numberExercises;
        }
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        
        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set { this.numberOfLectures = value; }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set { this.numberOfExercises = value; }
        }

    }
}
