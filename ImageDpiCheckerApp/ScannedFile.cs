using System;

namespace ImageDpiCheckerApp
{
    public class ScannedFile
    {
        public string Path { get; private set; }
        public string Name { get; private set; }
        public string Extension { get; private set; }
        public string Dpi { get; private set; }
        public string RealDpi { get; private set; }
        public string Scanner { get; private set; }
        public DateTime LastEdited { get; private set; }
        public long FileSize { get; private set; }
        public bool IsImage { get; private set; }


        public ScannedFile(string path, string name, string extension, string dpi, DateTime lastEdited, long fileSize, bool isImage, string realDpi = "unknown", string scanner = "unknown")
        {
            this.Path = path;
            this.Name = name;
            this.Extension = extension;
            this.Dpi = dpi;
            this.LastEdited = lastEdited;
            this.FileSize = fileSize;
            this.IsImage = isImage;
            this.RealDpi = realDpi;
            this.Scanner = scanner;
        }

    }
}
