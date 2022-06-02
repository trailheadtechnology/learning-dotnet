using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_05
{
    internal class Disposable
    {
        public void Main()
        {
            using (var s = new FileProcessor())
            {
                s.ProcessTheFile();
                // all the things
            }

            // identical to above
            var s2 = new FileProcessor();
            try
            {
                s2.ProcessTheFile();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                s2.Dispose();
            }
        }
    }

    public class FileProcessor : IDisposable
    {
        public void ProcessTheFile()
        {
            throw new Exception();
        }

        public void Dispose()
        {
            // clean up whatever resource
            // needs to be cleaned up quickly
        }
    }
}
