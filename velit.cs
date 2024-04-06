// Attempt to retrieve the directory names within the specified path.
try
{
    // Check if the directory exists to avoid a DirectoryNotFoundException.
    if (Directory.Exists(directoryPath))
    {
        // Get the names of all subdirectories within the specified directory.
        string[] folders = Directory.GetDirectories(directoryPath);

        // Optionally, perform operations on the retrieved directories.
        foreach (string folder in folders)
        {
            // For example, you can print the name of each directory.
            Console.WriteLine(folder);
        }
    }
    else
    {
        // Inform the user that the specified directory does not exist.
        Console.WriteLine($"The directory at path '{directoryPath}' does not exist.");
    }
}
catch (Exception ex)
{
    // Handle any exceptions that may occur during the directory retrieval process.
    Console.WriteLine($"An error occurred: {ex.Message}");
}
