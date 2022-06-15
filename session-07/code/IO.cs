using System;
using System.IO;

namespace session_07
{
    public class IO
    {
        public void Example()
        {
            var myfilecontents = File.ReadAllText(@"C:\path\to\file.txt"); //20 gb??

            using (var stream = File.OpenWrite($@"c:\temp\logs\2022-06-15.txt"))
            {
                byte[] mybytes = new byte[1024];
                var byteCount = stream.Read(mybytes, 0, 256);
            }

            var dirs = Directory.GetDirectories("c:\\");
            foreach(var dir in dirs)
            {
                new DirectoryInfo(dir).Attributes.HasFlag(FileAttributes.Hidden);

                var files = Directory.GetFiles(dir, "*.txt");
                foreach (var file in files)
                {
                    //File.Delete(file);
                    new FileInfo(file).Attributes.HasFlag(FileAttributes.Archive);
                }
            }
        }
    }
}
