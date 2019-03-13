using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace ImageDpiChecker
{
    class DpiChecker
    {
        public static List<Tuple<string, string, bool>> storedFiles = new List<Tuple<string, string, bool>>();

        public static string targetDirectory;

        static void Main(string[] args)
        {
            InitializeProgram(args);
        }

        public static void InitializeProgram(string[] args)
        {
            targetDirectory = GetTargetDirectory(args);

            var filters = GetFilters(args);

            var filteredFiles = GetFilesFrom(targetDirectory, filters);

            LoopThroughFiles(filteredFiles);


        }

        public static string GetTargetDirectory(string[] args)
        {
            string targetDirectory = string.Empty;
            if (args.Length > 0)
            {
                targetDirectory = args[0];
            }
            else
            {
                Console.WriteLine("Please select folder to scan for images");
                targetDirectory = Console.ReadLine();
            }
            if (!Directory.Exists(targetDirectory))
            {
                DpiExceptions.InvalidDirectory();
                GetTargetDirectory(args);
            }
            return targetDirectory;
        }

        public static void LoopThroughFiles(string[] filteredFiles)
        {
            bool hasException = false;
            foreach (var fileLoc in filteredFiles)
            {
                try
                {
                    Tuple<string, string, bool> currentImage = null;
                    string filename = Path.GetFileName(fileLoc);
                    currentImage = filename.Contains(".pdf") ? GetDPIFromPdf(fileLoc) : GetDPIFromImage(fileLoc);
                    storedFiles.Add(currentImage);
                }
                catch (Exception e)
                {
                    hasException = true;
                }
            }
            if (hasException)
                Console.WriteLine("An unexpected error has occurred and one or more DPI's could not be read");
            PrintResult(storedFiles);
        }

        public static string[] GetFilters(string[] args)
        {
            if (args.Length >= 1)
            {
                return args[1].Split(',');
            }
            Console.WriteLine();
            Console.WriteLine("What files do you want to display?");
            Console.WriteLine("Type as follows: pdf,jpg,tiff");
            string filters = Console.ReadLine();
            return filters.Split(',');
        }

        public static void PrintResult(List<Tuple<string, string, bool>> storedFiles)
        {
            try
            {
                Console.WriteLine(storedFiles.ToStringTable(
                      new[] { "Name", "DPI", "IsImage" },
                      a => a.Item1, a => a.Item2, a => a.Item3));
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while printing out the result");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static String[] GetFilesFrom(String searchFolder, String[] filters)
        {
            List<String> filesFound = new List<String>();
            try
            {

                foreach (var filter in filters)
                {
                    filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), SearchOption.AllDirectories));
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The given file path could not be found");
            }
            return filesFound.ToArray();
        }

        public static Tuple<string, string, bool> GetDPIFromImage(string fileLoc)
        {
            string filename = FormatFileName(fileLoc);

            return Tuple.Create(filename, Bitmap.FromFile(fileLoc).HorizontalResolution.ToString(), true);
        }

        public static Tuple<string, string, bool> GetDPIFromPdf(string fileLoc)
        {
            bool isPicture = false;
            string filename = FormatFileName(fileLoc);
            string dpiOfPDF = "---";
            using (var reader = new PdfReader(fileLoc))
            {
                PdfDictionary pg = reader.GetPageN(1);
                PdfDictionary res = (PdfDictionary)PdfReader.GetPdfObject(pg.Get(PdfName.RESOURCES));
                PdfDictionary xobjs = (PdfDictionary)PdfReader.GetPdfObject(res.Get(PdfName.XOBJECT));
                iTextSharp.text.Rectangle cropbox = reader.GetCropBox(1);
                var pageWidthInInch = cropbox.Width / 72;
                if (xobjs != null)
                {
                    foreach (PdfName xObjectKey in xobjs.Keys)
                    {
                        PdfObject xobj = xobjs.Get(xObjectKey);
                        PdfDictionary tg = (PdfDictionary)PdfReader.GetPdfObject(xobj);
                        PdfName subtype = (PdfName)PdfReader.GetPdfObject(tg.Get(PdfName.SUBTYPE));
                        if (subtype.Equals(PdfName.IMAGE))
                        {
                            PdfNumber width = (PdfNumber)tg.Get(PdfName.WIDTH);
                            PdfNumber height = (PdfNumber)tg.Get(PdfName.HEIGHT);
                            dpiOfPDF = Convert.ToString(width.FloatValue / pageWidthInInch);
                            isPicture = true;
                        }
                    }
                }
            }
            return Tuple.Create(filename, dpiOfPDF, isPicture);
        }
        
        public static string FormatFileName(string fileLoc)
        {
            string filename = fileLoc.Replace(targetDirectory, "");
            if (filename.Substring(0, 1) == @"\")
                return filename = filename.Substring(1);
            return filename;
        }

    }
}