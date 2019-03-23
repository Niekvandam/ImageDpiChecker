using System;

namespace ImageDpiCheckerApp
{
    public class ScannedFile
    {
        public string Path { get; private set; }
        public string Name { get; private set; }
        public string Extension { get; private set; }
        public string Version { get; private set; }
        public int Dpi { get; private set; }
        // public string RealDpi { get; private set; }
        public DateTime LastEdited { get; private set; }
        public long FileSize { get; private set; }
        public string Scanner { get; private set; }
        public string ScannerEng { get; private set; }
        public int Bpp { get; private set; }
        public int Pages { get; private set; }
        public int ImgCount { get; private set; }
        public string Dimension { get; private set; }
        public bool IsImage { get; private set; }


        public ScannedFile(string path, string name, string extension, string version, string dpi,int pages, int bpp, int imgCount,  DateTime lastEdited, long fileSize, bool isImage, string dimension = "unknown", string scanner = "unknown", string scannerEng="unknown")
        {
            this.Path = path;
            this.Name = name;
            this.Extension = extension;
            this.Dpi = Convert.ToInt32(dpi);
            this.LastEdited = lastEdited;
            this.FileSize = fileSize/1024;
            this.IsImage = isImage;
            //this.RealDpi = realDpi;
            this.Dimension = dimension;
            this.Bpp = bpp;
            this.Pages = pages;
            this.Version = version;
            this.ImgCount = imgCount;
            this.Scanner = scanner;
            this.ScannerEng = scannerEng;
        }

    }
}
