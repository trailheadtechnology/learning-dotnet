using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace session_07
{
    // HttpWebRequest - full control, slowest
    // WebClient - High-level abstraction, slower
    // HttpClient - the best of both (easy to use, fast, full-control)
    // RestSharp - nice third-party option
    public class HttpOptions
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task ExampleAsync()
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                var responseBody = await client.GetStringAsync(new Uri("https://www.google.com/"));
                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
