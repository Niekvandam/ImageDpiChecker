using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace ImageDpiCheckerApp
{
    public class ImageChecker
    {

        public List<ScannedFile> storedFiles = new List<ScannedFile>();

        public string targetDirectory;

        public string currentFilter;

        public List<String> filesFound = new List<String>();

        public List<ScannedFile> GetFilteredFiles(string directoryToScan, List<string> filters)
        {
            targetDirectory = directoryToScan;

            var filteredFiles = GetFilesFrom(targetDirectory, filters);

            return LoopThroughFiles(filteredFiles);
        }


        public List<ScannedFile> LoopThroughFiles(List<string> filteredFiles)
        {
            bool hasException = false;
            foreach (var fileLoc in filteredFiles)
            {
                try
                {
                    ScannedFile currentImage = null;
                    string filename = Path.GetFileName(fileLoc);
                    string extension = Path.GetExtension(fileLoc);
                    currentImage = extension == ".pdf" ? GetDPIFromPdf(fileLoc, extension) : GetDPIFromImage(fileLoc, extension);
                    storedFiles.Add(currentImage);
                }
                catch (Exception e)
                {
                    hasException = true;
                }
            }
            if (hasException)
            {


                Console.WriteLine("An unexpected error has occurred and one or more DPI's could not be read");
            }
            return storedFiles;
        }

        public List<String> GetFilesFrom(string searchFolder, List<string> filters)
        {


            foreach (string filter in filters)
            {
                currentFilter = filter;
                GetFilesRecursive(searchFolder);
            }

            return filesFound;
        }

        public String[] GetFilesRecursive(String searchFolder)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(searchFolder))
                {
                    GetFilesRecursive(d);
                }
                foreach (var file in Directory.GetFiles(searchFolder))
                {
                     if (file.ToLower().EndsWith(currentFilter.ToLower()))
                        filesFound.Add(file);
                }
            }
            catch (System.Exception e)
            {

            }
            return filesFound.ToArray();

        }

        public ScannedFile GetDPIFromImage(string fileLoc, string extension)
        {
            long length = new FileInfo(fileLoc).Length;
            string filename = FormatFileName(fileLoc);
            return new ScannedFile(fileLoc, Path.GetFileName(fileLoc), Path.GetExtension(fileLoc), Bitmap.FromFile(fileLoc).HorizontalResolution.ToString(),0, File.GetLastWriteTime(fileLoc), length, true);
        }
        
        public ScannedFile GetDPIFromPdf(string fileLoc, string extension)
        {
            bool isPicture = false;
            string filename = FormatFileName(fileLoc);
            string dpiOfPDF = "0";
            string realDpi = "---";
            string source = "unknown";
            string MaxDim = "";
            int bpp = 0;
              
            PdfReader pdf = new PdfReader(fileLoc);
           
            //if (obj != null && obj.IsStream())
            int xo = pdf.XrefSize;
            int imgCounter = 0;
            
            for (int i = 0; i < xo; i++)
            {
                
                PdfObject obj = pdf.GetPdfObject(i);
                if (obj != null && obj.IsStream())
                {
                    iTextSharp.text.Rectangle cropbox = pdf.GetCropBox(1);
                    
                    var pageWidthInInch = cropbox.Width / 72;
                    PdfDictionary pd = (PdfDictionary)obj;
                    if (pd.Contains(PdfName.SUBTYPE) && pd.Get(PdfName.SUBTYPE).ToString() == "/Image")
                    {
                        imgCounter++;
                        string filter = pd.Get(PdfName.FILTER).ToString();
                        string width = pd.Get(PdfName.WIDTH).ToString();
                        string height = pd.Get(PdfName.HEIGHT).ToString();
                        float ThisDpi = Convert.ToInt32(width) / pageWidthInInch;

                        if (ThisDpi > Convert.ToDouble(dpiOfPDF)) {
                            dpiOfPDF = Convert.ToString(Convert.ToInt32(ThisDpi));
                            bpp = Convert.ToInt32(pd.Get(PdfName.BITSPERCOMPONENT).ToString());
                            MaxDim = width + " x " + height;
                        }
                        isPicture = true;

                        realDpi = "Max:"+ MaxDim+ " )(bpp" + bpp + " )(images enclosed:"+Convert.ToString(imgCounter)+ " )(pages:" + Convert.ToString(pdf.NumberOfPages) + ")";
                    }
                    isPicture = true;
                }
            }
            long length = new FileInfo(fileLoc).Length;
            source = GetPDFFileinfo(pdf, "Producer");
            return new ScannedFile(fileLoc, Path.GetFileName(fileLoc), Path.GetExtension(fileLoc), dpiOfPDF,bpp, File.GetLastWriteTime(fileLoc), length, isPicture, realDpi, source);
        }


        public string FormatFileName(string fileLoc)
        {
            string filename = fileLoc.Replace(targetDirectory, "");
            if (filename.Substring(0, 1) == @"\")
                return filename = filename.Substring(1);
            return filename;
        }

        public string GetPDFFileinfo(PdfReader reader, string item)
        {
            string strValue = "unknown";
            //PdfReader reader = new PdfReader(FilePath);
            try
            {
                strValue=reader.Info[item];
                //reader.Info[item];
            }
            catch (System.Exception e) {
                return strValue;
            }

            return strValue;
        }
    }

    

}
