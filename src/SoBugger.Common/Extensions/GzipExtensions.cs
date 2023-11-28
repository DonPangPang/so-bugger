using System.IO.Compression;
using System.Text;

namespace SoBugger.Common.Extensions;

public static class GzipExtensions
{
    public static string GzipCompress(this string input)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(input);
        using (MemoryStream memoryStream = new MemoryStream())
        {
            using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress))
            {
                gzipStream.Write(bytes, 0, bytes.Length);
            }
            return Convert.ToBase64String(memoryStream.ToArray());
        }
    }

    public static string GzipDecompress(this string input)
    {
        byte[] bytes = Convert.FromBase64String(input);
        using (MemoryStream memoryStream = new MemoryStream(bytes))
        {
            using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
            {
                using (StreamReader reader = new StreamReader(gzipStream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
