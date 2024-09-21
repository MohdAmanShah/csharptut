using Spectre.Console; // to use Table

//SectionTitle("Handling cross-platform environments and filesystem");

//Table table = new Table();

//table.AddColumn("[blue]Member[/]");
//table.AddColumn("[blue]Value[/]");

//table.AddRow("Path.PathSeparator", Path.PathSeparator.ToString());
//table.AddRow("Path.DirectorySeparotorChar", Path.DirectorySeparatorChar.ToString());
//table.AddRow("Directory.GetCurrentDirectory()",
// GetCurrentDirectory());
//table.AddRow("Environment.CurrentDirectory", CurrentDirectory);
//table.AddRow("Environment.SystemDirectory", SystemDirectory);
//table.AddRow("Path.GetTempPath()", GetTempPath());
//table.AddRow("");
//table.AddRow("GetFolderPath(SpecialFolder", "");
//table.AddRow("  .System)", GetFolderPath(SpecialFolder.System));
//table.AddRow("  .ApplicationData)",
// GetFolderPath(SpecialFolder.ApplicationData));
//table.AddRow("  .MyDocuments)",
// GetFolderPath(SpecialFolder.MyDocuments));
//table.AddRow("  .Personal)",
// GetFolderPath(SpecialFolder.Personal));

//// Render the table to the console
//AnsiConsole.Write(table);



//SectionTitle("Managing drives");
//Table drives = new();
//drives.AddColumn("[blue]NAME[/]");
//drives.AddColumn("[blue]TYPE[/]");
//drives.AddColumn("[blue]FORMAT[/]");
//drives.AddColumn(new TableColumn(
// "[blue]SIZE (BYTES)[/]").RightAligned());
//drives.AddColumn(new TableColumn(
// "[blue]FREE SPACE[/]").RightAligned());
//foreach (DriveInfo drive in DriveInfo.GetDrives())
//{
//    if (drive.IsReady)
//    {
//        drives.AddRow(drive.Name, drive.DriveType.ToString(),
//          drive.DriveFormat, drive.TotalSize.ToString("N0"),
//          drive.AvailableFreeSpace.ToString("N0"));
//    }
//    else
//    {
//        drives.AddRow(drive.Name, drive.DriveType.ToString(),
//          string.Empty, string.Empty, string.Empty);
//    }
//}
//AnsiConsole.Write(drives);


//SectionTitle("Managing directories");

//string newFolder = Combine(GetFolderPath(Environment.SpecialFolder.Personal), "NewFolder");

//WriteLine($"Working with: {newFolder}");

//WriteLine($"Does it exist? {Path.Exists(newFolder)}");

//WriteLine("Creating it...");
//CreateDirectory(newFolder);

//WriteLine($"Does it exist? {Directory.Exists(newFolder)}");
//WriteLine("Confirm the directory exists, and press any key");
//ReadKey(intercept: true);

//WriteLine("Deleting it...");
//Delete(newFolder, recursive: true);
//WriteLine($"Does it exists? {Path.Exists(newFolder)}");



//SectionTitle("Managing Files");

//string dir = Combine(GetFolderPath(SpecialFolder.Personal), "OutputFiles");

//CreateDirectory(dir);

//string textFile = Combine(dir, "Dummy.txt");
//string backupFile = Combine(dir, "Dummy.bak");
//WriteLine($"Working with: {textFile}");
//WriteLine($"Does it exist? {File.Exists(textFile)}");


//StreamWriter textWriter = File.CreateText(textFile);
//textWriter.WriteLine("Hello C#!");
//textWriter.Close();
//WriteLine($"Does it exist? {File.Exists(textFile)}");

//File.Copy(textFile, backupFile, overwrite: true);

//WriteLine($"Does {backupFile} exist? {File.Exists(backupFile)}");
//Write("Confirm the files exist, and then press any key.");
//ReadKey(intercept: true);

//File.Delete(textFile);
//WriteLine($"Does it exist? {File.Exists(textFile)}");

//WriteLine($"Reading contents of {backupFile}");
//StreamReader textReader = File.OpenText(backupFile);
//WriteLine(textReader.ReadToEnd());
//textReader.Close();



//SectionTitle("Managing Paths");

//WriteLine($"Folder name: {GetDirectoryName(textFile)}");
//WriteLine($"File name: {Path.GetFileName(textFile)}");
//WriteLine($"File name without extension: {Path.GetFileNameWithoutExtension(textFile)}");
//WriteLine($"File extension: {Path.GetExtension(textFile)}");
//WriteLine($"Random file name: {Path.GetRandomFileName()}");
//WriteLine($"Temporary file name: {Path.GetTempFileName()}");

//StreamReader textReader = File.OpenText(Path.GetTempFileName());
//WriteLine(textReader.ReadToEnd());
//textReader.Close();

string textFile = Path.Combine(GetFolderPath(SpecialFolder.Personal), "Test.txt");
string backupFile = Path.Combine(GetFolderPath(SpecialFolder.Personal), "TextBackup.bak");
//StreamWriter textWriter = File.CreateText(textFile);
//textWriter.WriteLine("Hello, file");
//textWriter.Close();

SectionTitle("Getting file info.");

FileInfo info = new FileInfo(textFile);
WriteLine($"{textFile}");
WriteLine($" Size: {info.Length} bytes.");
WriteLine($" Last accessed: {info.LastAccessTime}");
WriteLine($" Has readonly set to {info.IsReadOnly}");
WriteLine($" Created on: {info.CreationTime}");
WriteLine($" Is file compressed: {info.Attributes.HasFlag(FileAttributes.Compressed)}.");

//FileStream file = File.Open(pathToFile,
//  FileMode.Open, FileAccess.Read, FileShare.Read);
//FileInfo info = new(backupFile);
//WriteLine("Is the backup file compressed? {0}",
// info.Attributes.HasFlag(FileAttributes.Compressed));


