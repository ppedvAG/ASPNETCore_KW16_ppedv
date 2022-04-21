using System.IO.Compression;

namespace ASPNETCore_WebAPI.Services
{
    public class FileService : IFileService
    {
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment _hostingEnvironment;

        public FileService(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }



        public void UploadFile(List<IFormFile> files, string subDirectory)
        {
            subDirectory = subDirectory ?? string.Empty;

            //Erstellen absoluten Pfad des Speicherortes
            string targetDirectory = Path.Combine(_hostingEnvironment.ContentRootPath, subDirectory);
            
            //Erstelle Unterverzeichnis
            if (!Directory.Exists(targetDirectory))
                Directory.CreateDirectory(targetDirectory);

            files.ForEach(async file =>
            {
                if (file.Length <= 0)
                    return;

                //absoluter ZielPfad der zu hochladenten Daten
                string filePath = Path.Combine(targetDirectory, file.FileName);

                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            });
        }


        public (string fileType, byte[] archiveData, string archiveName) DownloadFiles(string subDirectory)
        {
            //Name der Zip-Datei
            var zipName = $"archive-{DateTime.Now.ToString("yyyy_MM_dd-HH_mm_ss")}.zip";

            //Alle Datei-Pfade aus einem Unterverzeichnis werden in die Liste files gespeichert
            IList<string> files = Directory.GetFiles(Path.Combine(_hostingEnvironment.ContentRootPath, subDirectory)).ToList();

            byte[] compressBytes = GetZipArchive(files);

            return ("application/zip", compressBytes, zipName);
        }

        
        
        
        
        public string SizeConverter(long bytes)
        {
            var fileSize = new decimal(bytes);
            var kilobyte = new decimal(1024);
            var megabyte = new decimal(1024 * 1024);
            var gigabyte = new decimal(1024 * 1024 * 1024);

            switch (fileSize)
            {
                case var _ when fileSize < kilobyte:
                    return $"Less then 1KB";
                case var _ when fileSize < megabyte:
                    return $"{Math.Round(fileSize / kilobyte, 0, MidpointRounding.AwayFromZero):##,###.##}KB";
                case var _ when fileSize < gigabyte:
                    return $"{Math.Round(fileSize / megabyte, 2, MidpointRounding.AwayFromZero):##,###.##}MB";
                case var _ when fileSize >= gigabyte:
                    return $"{Math.Round(fileSize / gigabyte, 2, MidpointRounding.AwayFromZero):##,###.##}GB";
                default:
                    return "n/a";
            }
        }




        //Zip Datei erstellen
        private byte[] GetZipArchive(IList<string> filePaths)
        {
            List<InMemoryFile> files = new List<InMemoryFile>();

            foreach (string filePath in filePaths)
                files.Add(LoadFromFile(filePath));

            byte[] archiveFile;

            using (MemoryStream archiveStream = new MemoryStream())
            {
                using (ZipArchive archive = new ZipArchive(archiveStream, ZipArchiveMode.Create, true))
                {
                    foreach (InMemoryFile currentInMEmory in files)
                    {
                        ZipArchiveEntry zipArchiveEntry = archive.CreateEntry(currentInMEmory.FileName, CompressionLevel.Optimal);

                        using Stream zipStream = zipArchiveEntry.Open();

                        zipStream.Write(currentInMEmory.Content, 0, currentInMEmory.Content.Length);
                    }
                }
                archiveFile = archiveStream.ToArray();
            }

            return archiveFile;
        }

        private InMemoryFile LoadFromFile(string filePath)
        {
            using FileStream fs = File.OpenRead(filePath);

            using MemoryStream memFile = new MemoryStream();

            fs.CopyTo(memFile);
            
            memFile.Seek(0, SeekOrigin.Begin);

            return new InMemoryFile() {  Content = memFile.ToArray(), FileName = Path.GetFileName(filePath) };

            //using  enden hier  ->FileStream.Dispose und MemoryStream.Dispose wird hier aufgerufen 
        }
    }


    //Bei komprimieren einer Zip-DAtei, laden wir vorab alle Files jeweils in ein InMemoryFile
    class InMemoryFile
    {
        public string FileName { get; set; }    
        public byte[] Content { get; set; } 
    }
}
