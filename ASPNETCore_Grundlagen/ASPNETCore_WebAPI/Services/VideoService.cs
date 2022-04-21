namespace ASPNETCore_WebAPI.Services
{
    public class VideoService : IVideoService
    {
        private HttpClient httpClient;

        //HttpClient kommt aus IHttpClientFactory 
        public VideoService(HttpClient client)
        {
            httpClient = client;
        }

        public async Task<Stream> GetVideoByName(string name)
        {
            string url = string.Empty;

            switch (name)
            {
                case "fugees":
                    url = "http://gartner.gosimian.com/assets/videos/Fugees_ReadyOrNot_278-WIREDRIVE.mp4";
                    break;
                case "xyz":
                    url = "http://gartner.gosimian.com/assets/videos/George_Michael_MV-WIREDRIVE.mp4";
                    break;
                default:
                    url = "abc";
                    break;
            }

            return await httpClient.GetStreamAsync(url);
        }
    }
}
