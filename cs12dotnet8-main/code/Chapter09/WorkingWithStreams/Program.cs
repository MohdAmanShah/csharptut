/*
Stream Class - Members(not all)

    CanRead , CanWrite -- properties that determine whether we can read from or write to the stream.
    Length, Position -- properties that describes number of bytes in the stream and current position in the stream. This(Position) can                     throw [NotSupportedException] for some of the streams, if CanSeek return false.
    Close, Dispose -- This method close the stream and release its resourcse. Dispose implementation internally calls the Close() method.
    Flush --  If the Stream use some kind of buffer, then this method writes all bytes from the buffer to the file and the buffer is 
              cleared.
    CanSeek -- the property that defines if the Seek method can be used.
    Seek -- method that moves the current position to the on specified position in its parameter.
    Read, ReadAsync -- This method read specified numbers of bytes in bytes array and advance the position.
    ReadByte -- this method next byte from stream and advance the position.
    Write, WriteAsync -- This method writes the content of byte array to stream.
    WriteByte -- This method writes a byte to the stream.
    
StorageStreams - stream that defines where the bytes will be stored.
    
    System.IO - FileStream - in filesystem.
    System.IO - MemoryStream - memory in the current process.
    System.Net.Sockets - NetworkStream - in network location.

FunctionStreams - streams that can't exist on their own but can only be "plugged into" other streams to add functionality.

    System.Security.Cryptography - CryptoStream - encrypts and decrypts the stream.
    System.IO.Compression - GZipStream, DeflateStream - compress and decompress the stream.
    System.Net.Security - AuthenticatedStream - this send credentials across the stream.

Stream Helpers - Higher level class that can be used to manage streams. They make handling the stream easier than managing them using lower level classes. Some types are - 

    System.IO - StreamWriter, StreamReader - writes to and read from underlying stream as plain text.
    System.IO - BinaryReader, BinaryWriter - writes to and read from underlying stream as .Net types. Example - ReadDecimal() methods       will read the next 16bytes from stream as Decimal value. and WriteDecimal() method with decimal parameter writes 16 bytes to the    stream.
    System.Xml - XmlReader, XmlWriter - read from and write to underlying stream in XML format.
    

The Stream Pipeline -- we can combine different type of streams to perform different type of tasks.
Example  - 

    WriteLine("Hello World") -> StreamWriter -> CryptoStream -> GZipStream -> FileStream -> [file].
   
    using this stream pipeline - we can use simple helper method WriteLine("hello wordl"), to write a encryped and compressed stream of bytes to file.
 
 */

using Packt.Shared; // To use Viper;
using System.Text;
using System.Xml; // to use Xml and so on;

//SectionTitle("Writing to Text Streams.");

//// define a file to write to.
//string textFile = Combine(CurrentDirectory, "streams.txt");

//// create a text file and return a helper writer.
//StreamWriter text = File.CreateText(textFile);

//foreach(string item in Viper.Callsigns)
//{
//    text.WriteLine(item);
//}

//text.Close();

//OutputFileInfo(textFile);

//string xmlFile = Combine(CurrentDirectory, "streams.xml");

//FileStream? xmlFileStream = null;
//XmlWriter? xml = null;

//try
//{
//    xmlFileStream = File.Create(xmlFile);

//    xml = XmlWriter.Create(xmlFileStream, new XmlWriterSettings { Indent = true });

//    xml.WriteStartDocument();

//    xml.WriteStartElement("callsigns");

//    foreach (string sign in Viper.Callsigns)
//    {
//        xml.WriteElementString("callsign", sign);
//    }

//    xml.WriteEndElement();

//    xml.WriteStartElement("Name");

//    xml.WriteElementString("FirstName", "Mohd");
//    xml.WriteElementString("MiddleName", "Aman");
//    xml.WriteElementString("LastName", "Shah");

//    xml.WriteEndElement();

//    xml.WriteEndDocument();
//}
//catch (Exception ex)
//{
//    WriteLine($"{ex.GetType()} says {ex.Message}");
//}
//finally
//{
//    if (xml is not null)
//    {
//        xml.Close();
//        WriteLine("The XML Writer's unmanaged resources have been disposed.");
//    }
//    if (xmlFileStream is not null)
//    {
//        xmlFileStream.Close();
//        WriteLine("The file stream's unmanaged resources have been disposed.");
//    }
//}


//OutputFileInfo(xmlFile);


/*

using statement to simplify the code for checking the null object and then calling the Dispose method.


 */

//string path = Path.Combine(CurrentDirectory, "stream.txt");

//using (FileStream file = File.OpenWrite(path))
//{
//    using (StreamWriter writer = new StreamWriter(file))
//    {
//        try
//        {
//            writer.WriteLine("Welcome, .Net!");
//        }
//        catch (Exception ex)
//        {
//            WriteLine(ex.Message);
//        }
//    }
//}

//OutputFileInfo(path);

//using FileStream file = File.OpenWrite(path);
//using StreamWriter writer = new StreamWriter(file);

//try
//{
//    writer.WriteLine("Simplified file resource disposable.");
//}
//catch (Exception ex)
//{
//    WriteLine(ex.Message);
//}

//SectionTitle("Compressing Streams");


// XML file
//Compress(algorithm: "gzip");
//WriteLine();
//Compress(algorithm: "brotli");

// plain text file
//Compress(algorithm: "gzip", fileType: ".txt");
//WriteLine();
//Compress(algorithm: "brotli", fileType: ".txt");


//FileStream file = File.Open(Combine(CurrentDirectory, "streams.txt"), FileMode.Truncate);
//string text = "This is written using lower level FileStream class";
//byte[] bb = Encoding.UTF8.GetBytes(text);

//ReadOnlySpan<byte> buffer = bb.AsSpan();

//file.Write(buffer);

//file.Close();

//OutputFileInfo(Combine(CurrentDirectory, "streams.txt"));

