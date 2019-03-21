using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDpiCheckerApp
{
    public class ScannedFile
    {
        public string path;
        public string name;
        public string extension;
        public string dpi;
        public string realDpi;
        public string scanner;
        public DateTime lastEdited;
        public long fileSize;
        public bool isImage;
      

        public ScannedFile(string path, string name, string extension, string dpi, DateTime lastEdited, long fileSize, bool isImage, string realDpi = "unknown", string scanner = "unknown")
        {
            this.path = path;
            this.name = name;
            this.extension = extension;
            this.dpi = dpi;
            this.lastEdited = lastEdited;
            this.fileSize = fileSize;
            this.isImage = isImage;
            this.realDpi = realDpi;
            this.scanner = scanner;
        }
        
    }
}
