using System;
using System.IO;
using System.Xml;

namespace FileReadWriteApp.Model
{
    internal class FileReadWrite
    {
        private string _xmlPath= "C:\\Users\\Deepak\\source\\repos\\XMLFile1.xml";
        private string _htmlPath = "C:\\Users\\Deepak\\source\\repos\\HTMLPage1.html";
        private string _textPath = "C:\\Users\\Deepak\\source\\repos\\testfile.txt";
        public void ReadXmlFile()
        {
            string readText = File.ReadAllText(_xmlPath);
            Console.WriteLine(readText);
        }
        public void ReadHtmlFile()
        {
            string readText = File.ReadAllText(_htmlPath);
            Console.WriteLine(readText);
        }
        public void ReadTextFile()
        {
            string readText = File.ReadAllText(_textPath);
            Console.WriteLine(readText);
        }
        public void WriteXmlFile()
        {
            Console.WriteLine("Write in XML file\n");
            using (XmlWriter writer = XmlWriter.Create(_xmlPath))
            {
                Console.WriteLine("title");
                string title = Console.ReadLine();
                Console.WriteLine("author");
                string author = Console.ReadLine();
                Console.WriteLine("publisher");
                string publisher = Console.ReadLine();
                Console.WriteLine("price");
                string price = Console.ReadLine();
                writer.WriteStartElement("book");
                writer.WriteElementString("title", title);
                writer.WriteElementString("author", author);
                writer.WriteElementString("publisher", publisher);
                writer.WriteElementString("price", price);
                writer.WriteEndElement();
                writer.Flush();
            }
            
        }
        public void WriteHtmlFile()
        {
            Console.WriteLine("Write in HTML file\n");
            using (StreamWriter writetext = new StreamWriter(_htmlPath))
            {
                writetext.WriteLine(Console.ReadLine());
            }
        }
        public void WriteTextFile()
        {
            Console.WriteLine("Write in TEXT file\n");
            using (StreamWriter writetext = new StreamWriter(_textPath))
            {
                writetext.WriteLine(Console.ReadLine());
            }
        }
       
    }
}
