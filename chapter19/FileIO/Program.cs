using System.Text;
Streams();
static void Streams()
{
    File.Create("text.dat").Close();
    FileStream fs = new FileStream("text.dat", FileMode.Open);
    string data = "123445664";
    fs.Write(Encoding.UTF8.GetBytes(data), 0, data.Length);
    fs.Seek(0, SeekOrigin.Begin);
    byte[] buffer = new byte[1024];
    Console.WriteLine(fs.Read(buffer, 0, (int)fs.Length));
    Console.WriteLine(Encoding.UTF8.GetString(buffer));
    fs.Close();
    File.Delete("text.dat");
}
static void OpenFileWriteText()
{
    FileInfo f = new FileInfo("text.dat");
    using (StreamWriter sw = f.AppendText())
    {
        sw.WriteLine("");
        sw.WriteLine("OpenFileWriteText");
    }
    using (StreamReader sr = f.OpenText())
    {
        Console.WriteLine(sr.ReadToEnd());
    }
}


void CreateFile()
{
    FileInfo f = new FileInfo("text.dat");
    FileStream fs = f.Create();
    fs.Close();
}
void OpenFile()
{
    FileInfo f = new FileInfo("text.dat");
    using (FileStream fs = f.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
    {
        string data = "Don the Don";
        byte[] buffer = Encoding.UTF8.GetBytes(data);
        fs.WriteAsync(buffer, 0, buffer.Length);
        byte[] readbuffer = new byte[1024];
        int result = fs.Read(readbuffer, 0, buffer.Length);
        Console.WriteLine("Read {0} characters.", result);
        Console.WriteLine(Encoding.UTF8.GetString(readbuffer));
    }
}

static void OpenFileStreamReader()
{
    FileInfo f = new FileInfo("text.dat");
    using (StreamReader sr = f.OpenText())
    {
        string data = sr.ReadToEnd();
        Console.WriteLine(data);
    }

}