using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    public class Teacher : ITeacher
    {
        private string name;
        private List<ICourse> coursesList = new List<ICourse>();

        public List<ICourse> CoursesList
        {
            get
            {
                return this.coursesList;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.coursesList = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        public Teacher(string name)
        {
            this.Name = name;
        }

        public void AddCourse(ICourse course)
        {
            CoursesList.Add(course);
        }

        public override string ToString()
        {
            string teacherInfo = "";
            teacherInfo += "Teacher: Name=";
            teacherInfo += this.Name;

            if (coursesList.Count != 0)
            {
                teacherInfo += "; Courses=[";
                for (int i = 0; i < CoursesList.Count; i++)
                {
                    teacherInfo += CoursesList[i].Name.ToString();
                    if (i != CoursesList.Count - 1)
                    {
                        teacherInfo += ", ";
                    }
                }
                teacherInfo += "]";
            }

            return teacherInfo;
        }
    }

    public class Course : ICourse
    {
        protected string name;
        protected ITeacher teacher;
        protected List<string> topics = new List<string>();

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        public List<string> Topics
        {
            get
            {
                return this.topics;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.topics = value;
            }
        }

        public ITeacher Teacher
        {
            get
            {
                return this.teacher;
            }
            set
            {
                this.teacher = value;
            }
        }

        public void AddTopic(string topic)
        {
            this.Topics.Add(topic);
        }

    }

    public class LocalCourse : Course, ILocalCourse
    {
        private string lab;

        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.lab = value;
            }
        }

        public LocalCourse(string name, ITeacher teacher, string lab)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Lab = lab;
        }

        public override string ToString()
        {


            string courseInfo = "";
            courseInfo += this.GetType().Name.ToString();
            courseInfo += ": Name=";
            courseInfo += this.Name;
            courseInfo += ";";
            if (this.Teacher != null)
            {
                courseInfo += " Teacher=";
                courseInfo += this.Teacher.Name;
                courseInfo += ";";
            }
            if (this.Topics.Count != 0)
            {
                courseInfo += " Topics=[";
                for (int i = 0; i < topics.Count; i++)
                {
                    courseInfo += topics[i];
                    if (i != topics.Count - 1)
                    {
                        courseInfo += ", ";
                    }
                }
                courseInfo += "];";
            }
            courseInfo += " Lab=";
            courseInfo += this.Lab;

            return courseInfo;
        }
    }

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.town = value;
            }
        }

        public OffsiteCourse(string name, ITeacher teacher, string town)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Town = town;
        }

        public override string ToString()
        {

            string courseInfo = "";
            courseInfo += this.GetType().Name.ToString();
            courseInfo += ": Name=";
            courseInfo += this.Name;
            courseInfo += ";";
            if (this.Teacher != null)
            {
                courseInfo += " Teacher=";
                courseInfo += this.Teacher.Name;
                courseInfo += ";";
            }
            if (this.Topics.Count != 0)
            {
                courseInfo += " Topics=[";
                for (int i = 0; i < topics.Count; i++)
                {
                    courseInfo += topics[i];
                    if (i != topics.Count - 1)
                    {
                        courseInfo += ", ";
                    }
                }
                courseInfo += "];";
            }
            courseInfo += " Town=";
            courseInfo += this.Town;

            return courseInfo;
        }
    }


    public interface ITeacher
    {
        string Name { get; set; }
        void AddCourse(ICourse course);
        string ToString();
    }

    public interface ICourse
    {
        string Name { get; set; }
        ITeacher Teacher { get; set; }
        void AddTopic(string topic);
        string ToString();
    }

    public interface ILocalCourse : ICourse
    {
        string Lab { get; set; }
    }

    public interface IOffsiteCourse : ICourse
    {
        string Town { get; set; }
    }

    public interface ICourseFactory
    {
        ITeacher CreateTeacher(string name);
        ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab);
        IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town);
    }

    public class CourseFactory : ICourseFactory
    {
        public ITeacher CreateTeacher(string name)
        {
            Teacher teacher = new Teacher(name);
            return teacher;
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
        {
            ILocalCourse localCourse = new LocalCourse(name, teacher, lab);
            return localCourse;
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            IOffsiteCourse offsiteCourse = new OffsiteCourse(name, teacher, town);
            return offsiteCourse;
        }
    }

    public class SoftwareAcademyCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using SoftwareAcademy;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                        + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }
}
