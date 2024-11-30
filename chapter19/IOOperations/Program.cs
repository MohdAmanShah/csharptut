// ShowWindowsDirectoryInfo();
// DisplayImageFiles();
// ModifyAppDirectory();
ListDrivesAndDeletePrevious();

static void ShowWindowsDirectoryInfo()
{
    DirectoryInfo dir = new DirectoryInfo($@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Windows");
    Console.WriteLine("***** Directory Info *****");
    Console.WriteLine("FullName: {0}", dir.FullName);
    Console.WriteLine("Name: {0}", dir.Name);
    Console.WriteLine("Parent: {0}", dir.Parent);
    Console.WriteLine("Creation: {0}", dir.CreationTime);
    Console.WriteLine("Attributes: {0}", dir.Attributes);
    Console.WriteLine("Root: {0}", dir.Root);
    Console.WriteLine("**************************\n");
}

static void DisplayImageFiles()
{
    DirectoryInfo dir = new
    DirectoryInfo($@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Windows{Path.
    DirectorySeparatorChar}Web{Path.DirectorySeparatorChar}Wallpaper");
    // Get all files with a *.jpg extension.
    FileInfo[] imageFiles =
    dir.GetFiles("*", SearchOption.AllDirectories);
    // How many were found?
    Console.WriteLine("Found {0} *.jpg files\n", imageFiles.Length);
    // Now print out info for each file.
    foreach (FileInfo f in imageFiles.Where(f => f.Extension != ".jpg").ToList())
    {
        Console.WriteLine("***************************");
        Console.WriteLine("File name: {0}", f.Name);
        Console.WriteLine("File size: {0}", f.Length);
        Console.WriteLine("Creation: {0}", f.CreationTime);
        Console.WriteLine("Attributes: {0}", f.Attributes);
        Console.WriteLine("***************************\n");
    }
}


static void ModifyAppDirectory()
{
    DirectoryInfo dir = new DirectoryInfo(".");
    dir.CreateSubdirectory("MyFolder");
    DirectoryInfo dir2 = dir.CreateSubdirectory(@$"MyFolder2{Path.DirectorySeparatorChar}Data");
    Console.WriteLine("New Folder is: {0}", dir2);
}



static void ListDrivesAndDeletePrevious()
{
    string[] drives = Directory.GetLogicalDrives();
    foreach (string drive in drives)
    {
        Console.WriteLine(drive);
    }
    try
    {
        Directory.Delete("MyFolder");
        Directory.Delete("MyFolder2", true);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine(d.VolumeLabel);
