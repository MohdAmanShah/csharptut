using Packt.Shared; // To use viper
using System.IO.Compression; // To use BrotliStream, GZipStream
using System.Xml; // To use XmlWriter, XmlReader

partial class Program
{
    private static void Compress(string algorithm = "gzip")
    {
        string filePath = Combine(CurrentDirectory, $"streams.{algorithm}");
        Stream compressor;

        FileStream file = File.Create(filePath);

        if (algorithm == "gzip")
        {
            compressor = new GZipStream(file, CompressionMode.Compress);
        }
        else
        {
            compressor = new BrotliStream(file, CompressionMode.Compress);
        }

        using (compressor)
        {
            using (XmlWriter xmlWriter = XmlWriter.Create(compressor))
            {
                xmlWriter.WriteStartDocument();

                xmlWriter.WriteStartElement("callsigns");
                foreach (string sign in Viper.Callsigns)
                {
                    xmlWriter.WriteElementString("callsign", sign);
                }
                xmlWriter.WriteEndDocument();
            }
        } // also closes the underlying filestream

        OutputFileInfo(filePath);

        WriteLine("Reading the compressed XML file:");

        file = File.Open(filePath, FileMode.Open);
        Stream decompressor;

        if (algorithm == "gzip")
        {
            decompressor = new GZipStream(file, CompressionMode.Decompress);
        }
        else
        {
            decompressor = new BrotliStream(file, CompressionMode.Decompress);
        }

        using (decompressor)
        using (XmlReader reader = XmlReader.Create(decompressor))
            while (reader.Read())
            {
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "callsign"))
                {
                    reader.Read();
                    WriteLine($"{reader.Value}");
                }
            }
    }

    private static void Compress(string algorithm = "gzip", string fileType = ".txt")
    {
        string filePath = Combine(CurrentDirectory, $"streams.{algorithm}");
        Stream compressor;

        FileStream file = File.Create(filePath);

        if (algorithm == "gzip")
        {
            compressor = new GZipStream(file, CompressionMode.Compress);
        }
        else
        {
            compressor = new BrotliStream(file, CompressionMode.Compress);
        }

        using (compressor)
        {
            using (StreamWriter writer = new StreamWriter(compressor))
            {
                writer.WriteLine($"This is compress file using the {algorithm} algorithm.");
            }
        } // also closes the underlying filestream

        OutputFileInfo(filePath);

        WriteLine("Reading the compressed XML file:");

        file = File.Open(filePath, FileMode.Open);
        Stream decompressor;

        if (algorithm == "gzip")
        {
            decompressor = new GZipStream(file, CompressionMode.Decompress);
        }
        else
        {
            decompressor = new BrotliStream(file, CompressionMode.Decompress);
        }

        using (decompressor)
        using (StreamReader reader = new StreamReader(decompressor))
            WriteLine(reader.ReadToEnd());
    }
}