Console.WriteLine("File Search Tool");

Console.Write("Enter the directory to search: ");
string searchDirectory = Console.ReadLine();

Console.Write("Enter the file name (or '*' for any): ");
string fileName = Console.ReadLine();

Console.Write("Enter the file extension (or '*' for any): ");
string fileExtension = Console.ReadLine();

Console.Write("Enter the minimum file size in bytes (or 0 for any): ");
long minSize = Convert.ToInt64(Console.ReadLine());

SearchFiles(searchDirectory, fileName, fileExtension, minSize);
static void SearchFiles(string directory, string fileName, string fileExtension, long minSize)
{
    try
    {
        DirectoryInfo dirInfo = new DirectoryInfo(directory);
        FileInfo[] files = dirInfo.GetFiles($"{fileName ?? "*"}{fileExtension ?? "*"}");

        foreach (FileInfo file in files)
        {
            if (file.Length >= minSize)
            {
                Console.WriteLine($"File: {file.Name}\n   Path: {file.FullName}\n   Size: {file.Length} bytes\n");
            }
        }

        DirectoryInfo[] subDirectories = dirInfo.GetDirectories();

        foreach (DirectoryInfo subDirectory in subDirectories)
        {
            SearchFiles(subDirectory.FullName, fileName, fileExtension, minSize);
        }
    }
    catch (UnauthorizedAccessException)
    {
        Console.WriteLine($"Access to directory '{directory}' is denied.");
    }
    catch (DirectoryNotFoundException)
    {
        Console.WriteLine($"Directory '{directory}' not found.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
}