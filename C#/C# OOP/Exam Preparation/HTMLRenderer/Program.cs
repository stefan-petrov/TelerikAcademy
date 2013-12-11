using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    public interface IElement
    {
        string Name { get; }
        string TextContent { get; set; }
        IEnumerable<IElement> ChildElements { get; }
        void AddElement(IElement element);
        void Render(StringBuilder output);
        string ToString();
    }

    public interface ITable : IElement
    {
        int Rows { get; }
        int Cols { get; }
        IElement this[int row, int col] { get; set; }
    }

    public interface IElementFactory
    {
        IElement CreateElement(string name);
        IElement CreateElement(string name, string content);
        ITable CreateTable(int rows, int cols);
    }

    public class Table : ITable
    {
        private int rows;
        private int cols;

        private string textContent;
        private List<IElement> childElements = new List<IElement>();
        private IElement[,] matrix;

        public IElement[,] Matrix
        {
            get { return this.matrix; }
            set { this.matrix = value; }
        }

        public Table(int rows, int cols)
        {
            this.matrix = new Element[rows, cols];
        }

        public int Rows
        {
            get { return this.matrix.GetLength(0); }
        }

        public int Cols
        {
            get { return this.matrix.GetLength(1); }
        }

        public IElement this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        public string Name
        {
            get { return "table"; }
        }

        public string TextContent
        {
            get
            {
                return "";
            }
            set
            {
                this.textContent = value;
            }
        }

        public IEnumerable<IElement> ChildElements
        {
            get { return this.childElements; }

        }


        public void AddElement(IElement element)
        {
            childElements.Add(element);
        }

        public void Render(StringBuilder output)
        {
            output.Clear();
            StringBuilder sb = new StringBuilder();
            sb.Append("<table>");
            for (int i = 0; i < this.Rows; i++)
            {
                sb.Append("<tr>");
                for (int k = 0; k < this.Cols; k++)
                {
                    sb.Append("<td>");
                    Element temp = this.matrix[i, k] as Element;
                    sb.Append(temp.ToString());
                    sb.Append("</td>");
                }
                sb.Append("</tr>");
            }
            sb.Append("</table>");
            output.Append(sb.ToString());
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Render(sb);
            return sb.ToString();
        }

    }

    public class Element : IElement
    {
        private string textContent;
        private string name;
        private List<IElement> childElements = new List<IElement>();

        public Element(string name)
        {
            this.name = name;
        }

        public Element(string name, string textContent)
        {
            this.name = name;
            if (textContent != null)
            {
                textContent = textContent.Replace("&", "&amp;");
                textContent = textContent.Replace("<", "&lt;");
                textContent = textContent.Replace(">", "&gt;");
                this.textContent = textContent;
            }
        }

        public string Name
        {
            get { return this.name; }
        }

        public string TextContent
        {
            get
            {

                return this.textContent;
            }
            set
            {

                this.textContent = value;
            }
        }

        public IEnumerable<IElement> ChildElements
        {
            get { return this.childElements; }
        }

        public void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public void Render(StringBuilder output)
        {
            output.Clear();
            StringBuilder sb = new StringBuilder();
            if (this.name != null)
            {
                sb.Append("<" + this.Name + ">");
            }

            sb.Append(this.TextContent);
            foreach (var item in this.ChildElements)
            {
                sb.Append(item.ToString());
            }

            if (this.name != null)
            {
                sb.Append("</" + this.Name + ">");
            }
            output.Append(sb.ToString());
        }

        public override string ToString()
        {
            StringBuilder rendered = new StringBuilder();
            Render(rendered);
            return rendered.ToString();
        }
    }

    public class HTMLElementFactory : IElementFactory
    {
        public IElement CreateElement(string name)
        {
            IElement element = new Element(name);
            return element;
        }

        public IElement CreateElement(string name, string content)
        {
            IElement element = new Element(name, content);
            return element;
        }

        public ITable CreateTable(int rows, int cols)
        {
            ITable table = new Table(rows, cols);
            return table;
        }
    }

    public class HTMLRendererCommandExecutor
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
                  using HTMLRenderer;

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
