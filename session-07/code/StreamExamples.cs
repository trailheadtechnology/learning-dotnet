using System.IO;

namespace session_07
{
    public class StreamExamples
    {
        public static void Example()
        {
            string StartDirectory = @"c:\Users\exampleuser\start";
            string EndDirectory = @"c:\Users\exampleuser\end";

            foreach (string filename in Directory.EnumerateFiles(StartDirectory))
            {
                using (FileStream SourceStream = File.Open(filename, FileMode.Open))
                {
                    var outputFilePath = EndDirectory + filename.Substring(filename.LastIndexOf('\\'));
                    using (FileStream DestinationStream = File.Create(outputFilePath))
                    {
                        SourceStream.CopyTo(DestinationStream);
                    }
                }
            }
        }
    }
}
