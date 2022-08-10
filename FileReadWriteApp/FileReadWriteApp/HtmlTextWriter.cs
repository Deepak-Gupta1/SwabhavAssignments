using System.IO;

namespace FileReadWriteApp
{
    internal class HtmlTextWriter
    {
        private string path;
        private StringWriter stringWriter;

        public HtmlTextWriter(string path)
        {
            this.path = path;
        }

        public HtmlTextWriter(StringWriter stringWriter)
        {
            this.stringWriter = stringWriter;
        }
    }
}