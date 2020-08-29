using System.IO;

namespace GGSoftware.ApiClientService
{
    public class FileFormKeyValue : FormKeyValue
    {
        public Stream FileStream
        {
            get;
            set;
        }
        public string FileName
        {
            get;
            set;
        }
        public FileFormKeyValue(string key, Stream fileStream, string fileName) : base(key)
        {
            this.FileStream = fileStream;
            this.FileName = fileName;
        }
    }
}
