namespace TestHelpers;

public class HttpClientHelper
{
    private static readonly HttpClient httpClient;

    static HttpClientHelper()
    {
        var handler = new SocketsHttpHandler()
        {
            PooledConnectionLifetime = TimeSpan.FromMinutes(5)
        };
        
        httpClient = new HttpClient(handler, disposeHandler: false);
        
    }

    public HttpClient GetHttpClient()
    {
        return HttpClientHelper.httpClient;
    }
    
}