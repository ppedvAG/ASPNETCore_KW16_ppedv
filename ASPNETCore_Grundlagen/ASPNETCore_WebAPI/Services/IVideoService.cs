namespace ASPNETCore_WebAPI.Services
{
    public interface IVideoService
    {
        Task<Stream> GetVideoByName(string name);
    }
}
