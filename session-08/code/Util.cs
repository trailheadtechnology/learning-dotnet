using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace session_08
{
    public static class Util
    {
        public static long GetSizeOfObject(object obj)
        {
            long size = 0;
            using (Stream s = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(s, obj);
                size = s.Length;
            }
            return size;
        }
    }
}
