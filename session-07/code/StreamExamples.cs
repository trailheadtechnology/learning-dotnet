using System.IO;
using System.Text;

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

        public static void StreamReaderWriterExample()
        {
            using (StreamReader reader = new StreamReader("input.txt"))
            {
                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    // Read each line from the input file
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Write the line to the output file
                        writer.WriteLine(line);
                    }
                }
            }
        }
    }
}
