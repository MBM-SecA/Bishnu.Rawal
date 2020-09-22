using System;
using System.IO;
public class FileIO
{
    public void LearnFileHandling()
    {
        string fileName = "file.txt";
        if (File.Exists(fileName))
        {
            string fileContent = File.ReadAllText(fileName);
            Console.WriteLine(fileContent);
        }

        File.WriteAllText(fileName, "This is just a test file");
    }

    public void LearnFileInfo()
    {
        string fileName = "file.txt";
        FileInfo fileInfo = new FileInfo(fileName);
        var size = fileInfo.Length;
        var createdDate = fileInfo.CreationTime;

        Console.WriteLine($"File Size: {size} bytes");
        Console.WriteLine($"Created: {createdDate}");
    }
    
    public void LearnDirectories()
    {
        string directoryName = "A";
        Directory.CreateDirectory(directoryName);        
    }
}

    // HW: Create a folder "ABC", create 10 subfolders in "ABC". Each subfolder
    // should contain a C# file with hello world program.