using System;
using System.IO;
using System.Threading.Tasks;

public class FileWriter
{
    public async Task WriteMessageToFileAsync(string message)
    {
        // Delay to simulate background operation (3 seconds)
        await Task.Delay(3000);
   
        await File.WriteAllTextAsync("tmp.txt", message);
    }
}

class KioskSystem
{
    static async Task Main(string[] args)
    {

        FileWriter updateFile = new FileWriter();

        // Main loop for the Kiosk System
        while (true)
        {
         
            Console.WriteLine("Kiosk System Menu:");
            Console.WriteLine("1. Write 'Hello World'");
            Console.WriteLine("2. Write Current Date");
            Console.WriteLine("3. Write OS Version");
            Console.WriteLine("Enter your choice (1/2/3) or 'q' to quit:");

            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    await WriteMessage("Hello World", updateFile);
                    break;
                case "2":
                    await WriteMessage(DateTime.Now.ToString(), updateFile);
                    break;
                case "3":
                    await WriteMessage(Environment.OSVersion.VersionString, updateFile);
                    break;
                case "q":
                    Console.WriteLine("Exiting..");
                    return;
                default:
                    // Invalid input message
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Method to write message to file asynchronously
    static async Task WriteMessage(string message, FileWriter updateFile)
    {
        // Inform user about writing operation
        Console.WriteLine("Updating the tmp file..");
        await updateFile.WriteMessageToFileAsync(message);
        Console.WriteLine("Writing completed Successfully");
    }
}
