using System.Drawing;
using System.IO;
using System.Windows;


namespace DataParallelism;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
    public MainWindow()
    {
        InitializeComponent();
    }
    private void cmdCancel_Click(object sender, EventArgs e)
    {
        cancellationTokenSource.Cancel();
    }

    private void cmdProcess_Click(object sender, EventArgs e)
    {
        this.Title = $"Starting...";
        Task.Factory.StartNew(() => { ProcessFiles(); });
    }
    private void ProcessFiles()
    {
        var baseDirectory = Directory.GetCurrentDirectory();
        var pictureDirectory = System.IO.Path.Combine(baseDirectory, "TestFiles");
        var outputDirectory = System.IO.Path.Combine(baseDirectory, "ModifiedPictures");
        if (Directory.Exists(outputDirectory))
        {
            Directory.Delete(outputDirectory, true);
        }
        Directory.CreateDirectory(outputDirectory);
        string[] files = Directory.GetFiles(pictureDirectory, "*.jpg", SearchOption.AllDirectories);
        ParallelOptions parallelOptions = new ParallelOptions();
        parallelOptions.CancellationToken = cancellationTokenSource.Token;
        try
        {
            System.Threading.Tasks.Parallel.ForEach(files, parallelOptions, (currentFile) =>
            {
                parallelOptions.CancellationToken.ThrowIfCancellationRequested();
                string filename = System.IO.Path.GetFileName(currentFile);
                Dispatcher?.Invoke(() =>
                {
                    this.Title = $"Processing {filename} at thread {Environment.CurrentManagedThreadId}";
                });
                using (Bitmap bitmap = new Bitmap(currentFile))
                {
                    bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    bitmap.Save(System.IO.Path.Combine(outputDirectory, filename));
                }
            });
            Dispatcher?.Invoke(() =>
            {
                this.Title = "Processing Done";
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Dispatcher?.Invoke(() =>
            {
                this.Title = $"{ex.Message}";
            });
        }
    }

}