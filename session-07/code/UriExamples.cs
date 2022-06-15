using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_07
{
    public class UriExamples
    {
        public static void Example()
        {
            Uri uri = new Uri("https://user:password@www.contoso.com:80/Home/Index.htm?q1=v1&q2=v2#FragmentName");
            
            Console.WriteLine($"AbsolutePath: {uri.AbsolutePath}");
            Console.WriteLine($"AbsoluteUri: {uri.AbsoluteUri}");
            Console.WriteLine($"DnsSafeHost: {uri.DnsSafeHost}");
            Console.WriteLine($"Fragment: {uri.Fragment}");
            Console.WriteLine($"Host: {uri.Host}");
            Console.WriteLine($"HostNameType: {uri.HostNameType}");
            Console.WriteLine($"IdnHost: {uri.IdnHost}");
            Console.WriteLine($"IsAbsoluteUri: {uri.IsAbsoluteUri}");
            Console.WriteLine($"IsDefaultPort: {uri.IsDefaultPort}");
            Console.WriteLine($"IsFile: {uri.IsFile}");
            Console.WriteLine($"IsLoopback: {uri.IsLoopback}");
            Console.WriteLine($"IsUnc: {uri.IsUnc}");
            Console.WriteLine($"LocalPath: {uri.LocalPath}");
            Console.WriteLine($"OriginalString: {uri.OriginalString}");
            Console.WriteLine($"PathAndQuery: {uri.PathAndQuery}");
            Console.WriteLine($"Port: {uri.Port}");
            Console.WriteLine($"Query: {uri.Query}");
            Console.WriteLine($"Scheme: {uri.Scheme}");
            Console.WriteLine($"Segments: {string.Join(", ", uri.Segments)}");
            Console.WriteLine($"UserEscaped: {uri.UserEscaped}");
            Console.WriteLine($"UserInfo: {uri.UserInfo}");
        }
    }
}
