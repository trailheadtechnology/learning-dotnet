using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace session_06
{
    // accessing files in file system
    // accessing web sites
    // accessing databases
    // texting/emailing
    // anything that might take longer to finish without using the processor
    public class AsyncAwait
    {
        public int GetUrlContentLength()
        {
            var client = new HttpClient();
            // synchronized an async method, but block the thread (bad)
            var contents = client.GetStringAsync("https://docs.microsoft.com/dotnet").Result;
            DoIndependentWork();
            return contents.Length;
        }

        public async Task<int> GetUrlContentLengthAsync()
        {
            var client = new HttpClient();
            // synchronized an async method, but DON'T block the thread (good)
            var contents = await client.GetStringAsync("https://docs.microsoft.com/dotnet");
            DoIndependentWork();
            return contents.Length;
        }

        public async Task<int> GetUrlContentLengthParallelAsync()
        {
            var client = new HttpClient();
            // parrallelizing an async method, AND NOT blocking the thread (cool)
            Task<string> getStringTask = client.GetStringAsync("https://docs.microsoft.com/dotnet");
            DoIndependentWork();
            string contents = await getStringTask;

            return contents.Length;
        }

        void DoIndependentWork()
        {
            Console.WriteLine("Working...");
        }
    }
}
