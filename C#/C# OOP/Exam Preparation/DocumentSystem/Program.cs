using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    public interface IDocument
    {
        string Name { get; }
        string Content { get; }
        void LoadProperty(string key, string value);
        void SaveAllProperties(IList<KeyValuePair<string, object>> output);
        string ToString();
    }

    public interface IEditable
    {
        void ChangeContent(string newContent);
    }

    public interface IEncryptable
    {
        bool IsEncrypted { get; }
        void Encrypt();
        void Decrypt();
    }

    public class DocumentSystem
    {
        List<string> documents = new List<string>();

        static void Main()
        {
            IList<string> allCommands = ReadAllCommands();
            ExecuteCommands(allCommands);
        }

        private static IList<string> ReadAllCommands()
        {
            List<string> commands = new List<string>();
            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == "")
                {
                    // End of commands
                    break;
                }
                commands.Add(commandLine);
            }
            return commands;
        }

        private static void ExecuteCommands(IList<string> commands)
        {
            foreach (var commandLine in commands)
            {
                int paramsStartIndex = commandLine.IndexOf("[");
                string cmd = commandLine.Substring(0, paramsStartIndex);
                int paramsEndIndex = commandLine.IndexOf("]");
                string parameters = commandLine.Substring(
                    paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
                ExecuteCommand(cmd, parameters);
            }
        }

        private static void ExecuteCommand(string cmd, string parameters)
        {
            string[] cmdAttributes = parameters.Split(
                new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (cmd == "AddTextDocument")
            {
                AddTextDocument(cmdAttributes);
            }
            else if (cmd == "AddPDFDocument")
            {
                AddPdfDocument(cmdAttributes);
            }
            else if (cmd == "AddWordDocument")
            {
                AddWordDocument(cmdAttributes);
            }
            else if (cmd == "AddExcelDocument")
            {
                AddExcelDocument(cmdAttributes);
            }
            else if (cmd == "AddAudioDocument")
            {
                AddAudioDocument(cmdAttributes);
            }
            else if (cmd == "AddVideoDocument")
            {
                AddVideoDocument(cmdAttributes);
            }
            else if (cmd == "ListDocuments")
            {
                ListDocuments();
            }
            else if (cmd == "EncryptDocument")
            {
                EncryptDocument(parameters);
            }
            else if (cmd == "DecryptDocument")
            {
                DecryptDocument(parameters);
            }
            else if (cmd == "EncryptAllDocuments")
            {
                EncryptAllDocuments();
            }
            else if (cmd == "ChangeContent")
            {
                ChangeContent(cmdAttributes[0], cmdAttributes[1]);
            }
            else
            {
                throw new InvalidOperationException("Invalid command: " + cmd);
            }
        }

        private static void AddTextDocument(string[] attributes)
        {

            if (attributes.Length == 0)
            {
                Console.WriteLine("Document has no name");
            }
            else
            {
                TextDoc txtDoc = new TextDoc();
                for (int i = 0; i < attributes.Length; i++)
                {
                    string propName = ReturnPropName(attributes[i]);
                    string propValue = ReturnPropValue(attributes[i]);
                    if (propName == "name")
                    {
                        Console.WriteLine("Document added: " + propValue);

                    }
                    txtDoc.LoadProperty(propName, propValue);

                }

                if (txtDoc.Name == null)
                {
                    Console.WriteLine("Document has no name");
                }
                else
                {
                    DocumentsList.Documents.Add(txtDoc);
                }

            }
        }

        private static void AddPdfDocument(string[] attributes)
        {
            if (attributes.Length == 0)
            {
                Console.WriteLine("Document has no name");
            }
            else
            {
                PDFDoc pdfDoc = new PDFDoc();
                for (int i = 0; i < attributes.Length; i++)
                {
                    string propName = ReturnPropName(attributes[i]);
                    string propValue = ReturnPropValue(attributes[i]);
                    if (propName == "name")
                    {
                        Console.WriteLine("Document added: " + propValue);

                    }
                    pdfDoc.LoadProperty(propName, propValue);

                }

                if (pdfDoc.Name == null)
                {
                    Console.WriteLine("Document has no name");
                }
                else
                {
                    DocumentsList.Documents.Add(pdfDoc);
                }
            }
        }

        private static void AddWordDocument(string[] attributes)
        {
            if (attributes.Length == 0)
            {
                Console.WriteLine("Document has no name");
            }
            else
            {
                WordDoc wordDoc = new WordDoc();
                for (int i = 0; i < attributes.Length; i++)
                {
                    string propName = ReturnPropName(attributes[i]);
                    string propValue = ReturnPropValue(attributes[i]);
                    if (propName == "name")
                    {
                        Console.WriteLine("Document added: " + propValue);

                    }
                    wordDoc.LoadProperty(propName, propValue);

                }

                if (wordDoc.Name == null)
                {
                    Console.WriteLine("Document has no name");
                }
                else
                {
                    DocumentsList.Documents.Add(wordDoc);
                }
            }
        }

        private static void AddExcelDocument(string[] attributes)
        {
            if (attributes.Length == 0)
            {
                Console.WriteLine("Document has no name");
            }
            else
            {
                ExcelDoc exlDoc = new ExcelDoc();
                for (int i = 0; i < attributes.Length; i++)
                {
                    string propName = ReturnPropName(attributes[i]);
                    string propValue = ReturnPropValue(attributes[i]);
                    if (propName == "name")
                    {
                        Console.WriteLine("Document added: " + propValue);

                    }
                    exlDoc.LoadProperty(propName, propValue);

                }

                if (exlDoc.Name == null)
                {
                    Console.WriteLine("Document has no name");
                }
                else
                {
                    DocumentsList.Documents.Add(exlDoc);
                }
            }
        }

        private static void AddAudioDocument(string[] attributes)
        {
            if (attributes.Length == 0)
            {
                Console.WriteLine("Document has no name");
            }
            else
            {
                AudioDoc audioDoc = new AudioDoc();
                for (int i = 0; i < attributes.Length; i++)
                {
                    string propName = ReturnPropName(attributes[i]);
                    string propValue = ReturnPropValue(attributes[i]);
                    if (propName == "name")
                    {
                        Console.WriteLine("Document added: " + propValue);

                    }
                    audioDoc.LoadProperty(propName, propValue);

                }

                if (audioDoc.Name == null)
                {
                    Console.WriteLine("Document has no name");
                }
                else
                {
                    DocumentsList.Documents.Add(audioDoc);
                }
            }
        }

        private static void AddVideoDocument(string[] attributes)
        {
            if (attributes.Length == 0)
            {
                Console.WriteLine("Document has no name");
            }
            else
            {
                VideoDoc videoDoc = new VideoDoc();
                for (int i = 0; i < attributes.Length; i++)
                {
                    string propName = ReturnPropName(attributes[i]);
                    string propValue = ReturnPropValue(attributes[i]);
                    if (propName == "name")
                    {
                        Console.WriteLine("Document added: " + propValue);

                    }
                    videoDoc.LoadProperty(propName, propValue);

                }

                if (videoDoc.Name == null)
                {
                    Console.WriteLine("Document has no name");
                }
                else
                {
                    DocumentsList.Documents.Add(videoDoc);
                }
            }
        }

        private static void ListDocuments()
        {
            foreach (var item in DocumentsList.Documents)
            {
                Console.WriteLine(item);
            }
        }

        private static void EncryptDocument(string name)
        {
            int count = 0;
            foreach (IDocument item in DocumentsList.Documents)
            {
                if (item.Name == name)
                {
                    if (item is IEncryptable)
                    {
                        IEncryptable temp = item as IEncryptable;
                        temp.Encrypt();
                        Console.WriteLine("Document encrypted: " + item.Name);
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Document does not support encryption: " + item.Name);
                        count++;
                    }
                }

            }

            if (count == 0)
            {
                Console.WriteLine("Document not found: " + name);
            }
        }

        private static void DecryptDocument(string name)
        {
            int count = 0;
            foreach (IDocument item in DocumentsList.Documents)
            {
                if (item.Name == name)
                {
                    if (item is IEncryptable)
                    {
                        IEncryptable test = item as IEncryptable;
                        test.Decrypt();
                        Console.WriteLine("Document decrypted: " + item.Name);
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Document does not support decryption: " + item.Name);
                        count++;
                    }
                }

            }

            if (count == 0)
            {
                Console.WriteLine("Document not found: " + name);
            }
        }

        private static void EncryptAllDocuments()
        {
            int count = 0;
            foreach (var item in DocumentsList.Documents)
            {
                if (item is IEncryptable)
                {
                    Console.WriteLine("All documents encrypted");
                    IEncryptable temp = item as IEncryptable;
                    temp.Encrypt();
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No encryptable documents found");
            }

        }

        private static void ChangeContent(string name, string content)
        {
            int count = 0;
            foreach (var item in DocumentsList.Documents)
            {
                if (item.Name == name)
                {
                    if (item is IEditable)
                    {
                        Console.WriteLine("Document content changed: " + item.Name);
                        IEditable test = (IEditable)item;
                        test.ChangeContent(content);
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Document is not editable: " + item.Name);
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Document not found: " + name);
            }
        }

        private static string ReturnPropName(string str)
        {
            int paramStartIndex = str.IndexOf("=");
            string propName = str.Substring(0, paramStartIndex);
            return propName;
        }

        private static string ReturnPropValue(string str)
        {
            int paramStartIndex = str.IndexOf("=");
            string value = str.Substring(paramStartIndex + 1, str.Length - 1 - paramStartIndex);
            return value;
        }
    }

    class TextDoc : IDocument, IText, IEditable
    {

        public string Name { get; set; }
        public string Content { get; set; }
        public string Charset { get; set; }

        public TextDoc()
        {
        }

        public void LoadProperty(string key, string value)
        {
            switch (key)
            {
                case "name": this.Name = value;
                    break;
                case "charset": this.Charset = value;
                    break;
                case "content": this.Content = value;
                    break;
                default:
                    break;
            }
        }

        public void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string str = (this.Charset == null ? "" : "charset=" + this.Charset) + (this.Content == null ? "" : ";content=" + this.Content) + ";name=" + this.Name;
            if (str.StartsWith(";"))
            {
                str = str.Substring(1, str.Length - 1);
            }
            return "TextDocument[" + str + "]";
        }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }
    }

    class PDFDoc : IDocument, IEncryptable, IBinary
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string Pages { get; set; }
        public string Size { get; set; }
        public bool IsEncrypted { get; set; }

        public PDFDoc()
        {
        }

        public void LoadProperty(string key, string value)
        {
            switch (key)
            {
                case "name": this.Name = value;
                    break;
                case "pages": this.Pages = value;
                    break;
                case "content": this.Content = value;
                    break;
                case "size": this.Size = value;
                    break;
                default:
                    break;
            }
        }

        public void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            if (this.IsEncrypted == true)
            {
                return "PDFDocument[encrypted]";
            }
            else
            {
                string str = (this.Content == null ? "" : "content=" + this.Content) + ";name=" + this.Name + (this.Pages == null ? "" : ";pages=" + this.Pages) + (this.Size == null ? "" : ";size=" + this.Size);
                if (str.StartsWith(";"))
                {
                    str = str.Substring(1, str.Length - 1);
                }
                return "PDFDocument[" + str + "]";
            }
        }

        public void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public void Decrypt()
        {
            this.IsEncrypted = false;
        }
    }

    class WordDoc : IDocument, IBinary, IEditable, IEncryptable, IOffice
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string NumOfChars { get; set; }
        public string Size { get; set; }
        public bool IsEncrypted { get; set; }
        public string Version { get; set; }


        public void LoadProperty(string key, string value)
        {
            switch (key)
            {
                case "name": this.Name = value;
                    break;
                case "content": this.Content = value;
                    break;
                case "chars": this.NumOfChars = value;
                    break;
                case "size": this.Size = value;
                    break;
                case "version": this.Version = value;
                    break;
                default:
                    break;
            }
        }

        public void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            throw new NotImplementedException();
        }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }

        public void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public void Decrypt()
        {
            this.IsEncrypted = false;
        }

        public override string ToString()
        {
            if (this.IsEncrypted == true)
            {
                return "WordDocument[encrypted]";
            }
            else
            {
                string str = (this.NumOfChars == null ? "" : "chars=" + this.NumOfChars) + (this.Content == null ? "" : "content=" + this.Content) + ";name=" + this.Name + (this.Size == null ? "" : ";size=" + this.Size) + (this.Version == null ? "" : ";version=" + this.Version);
                if (str.StartsWith(";"))
                {
                    str = str.Substring(1, str.Length - 1);
                }
                return "WordDocument[" + str + "]";
            }
        }
    }

    class ExcelDoc : IDocument, IBinary, IOffice, IEncryptable
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string Rows { get; set; }
        public string Cols { get; set; }
        public string Size { get; set; }
        public bool IsEncrypted { get; set; }
        public string Version { get; set; }

        public void LoadProperty(string key, string value)
        {
            switch (key)
            {
                case "name": this.Name = value;
                    break;
                case "content": this.Content = value;
                    break;
                case "rows": this.Rows = value;
                    break;
                case "cols": this.Cols = value;
                    break;
                case "size": this.Size = value;
                    break;
                case "version": this.Version = value;
                    break;
                default:
                    break;
            }
        }

        public void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            throw new NotImplementedException();
        }

        public void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public void Decrypt()
        {
            this.IsEncrypted = false;
        }

        public override string ToString()
        {
            if (IsEncrypted == true)
            {
                return "ExcelDocument[encrypted]";
            }
            else
            {
                string str = (this.Cols == null ? "" : "cols=" + this.Cols) + (this.Content == null ? "" : "content=" + this.Content) + ";name=" + this.Name + (this.Rows == null ? "" : "rows=" + this.Rows) + (this.Size == null ? "" : ";size=" + this.Size) + (this.Version == null ? "" : ";version=" + this.Version);
                if (str.StartsWith(";"))
                {
                    str = str.Substring(1, str.Length - 1);
                }
                return "ExcelDocument[" + str + "]";
            }
        }

    }

    class AudioDoc : IDocument, IBinary, IMultimedia
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string Size { get; set; }
        public string Rate { get; set; }
        public string Length { get; set; }

        public void LoadProperty(string key, string value)
        {
            switch (key)
            {
                case "name": this.Name = value;
                    break;
                case "content": this.Content = value;
                    break;
                case "length": this.Length = value;
                    break;
                case "samplerate": this.Rate = value;
                    break;
                case "size": this.Size = value;
                    break;
                default:
                    break;
            }
        }

        public void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            string str = (this.Content == null ? "" : "content=" + this.Content) + (this.Length == null ? "" : ";length=" + this.Length) + ";name=" + this.Name + (this.Rate == null ? "" : ";samplerate=" + this.Rate) + (this.Size == null ? "" : ";size=" + this.Size);
            if (str.StartsWith(";"))
            {
                str = str.Substring(1, str.Length - 1);
            }
            return "AudioDocument[" + str + "]";
        }
    }

    class VideoDoc : IDocument, IMultimedia, IBinary
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string Size { get; set; }
        public string FrameRate { get; set; }
        public string Length { get; set; }

        public void LoadProperty(string key, string value)
        {
            switch (key)
            {
                case "name": this.Name = value;
                    break;
                case "content": this.Content = value;
                    break;
                case "length": this.Length = value;
                    break;
                case "framerate": this.FrameRate = value;
                    break;
                case "size": this.Size = value;
                    break;
                default:
                    break;
            }
        }

        public void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            string str = (this.Content == null ? "" : "content=" + this.Content) + (this.FrameRate == null ? "" : "framerate=" + this.FrameRate) + (this.Length == null ? "" : ";length=" + this.Length) + ";name=" + this.Name + (this.Size == null ? "" : ";size=" + this.Size);
            if (str.StartsWith(";"))
            {
                str = str.Substring(1, str.Length - 1);
            }
            return "VideoDocument[" + str + "]";
        }
    }

    class DocumentsList
    {
        private static List<IDocument> documents = new List<IDocument>();

        public static List<IDocument> Documents
        {
            get { return documents; }
            set { documents = value; }
        }
    }

    interface IText
    {
        string Charset { get; set; }
    }

    interface IBinary
    {
        string Size { get; set; }
    }

    interface IOffice
    {
        string Version { get; set; }
    }

    interface IMultimedia
    {
        string Length { get; set; }
    }
}
