namespace ASPNETCore_WebAPI.Services
{
    public interface IFileService
    {

        /// <summary>
        /// Upload von Dateien
        /// </summary>
        /// <param name="files">multiple</param>
        /// <param name="subDirectory">Upload-Ziel</param>
        void UploadFile(List<IFormFile> files, string subDirectory);


        /// <summary>
        /// Download von Dateien als Zip
        /// </summary>
        /// <param name="subDirectory"></param>
        /// <returns></returns>
        (string fileType, byte[] archiveData, string archiveName) DownloadFiles(string subDirectory);


        /// <summary>
        /// Upload Größenangabe als String
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        string SizeConverter(long bytes);
    }
}
