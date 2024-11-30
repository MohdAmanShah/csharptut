GetDrivesInfo();
void GetDrivesInfo()
{
    DriveInfo[] myDrives = DriveInfo.GetDrives();
    foreach (DriveInfo d in myDrives)
    {
        Console.WriteLine(d.Name);
        Console.WriteLine(d.DriveType);
        if (d.IsReady)
        {
            Console.WriteLine($"Free space: {d.TotalFreeSpace / (1024 * 1024)}");
            Console.WriteLine($"Formate: {d.DriveFormat}");
            Console.WriteLine($"Label: {d.VolumeLabel}");
        }
    }
    Console.WriteLine();
}