# Kiosk - File Writer

## Overview
This project implements a non-blocking console user interface for a Kiosk system. In a non-blocking system, the user interface remains responsive while executing potentially blocking operations such as writing to a file. The Kiosk system presents a menu to the user, allowing them to choose from options to write specific messages to a file.

## Menu Options
The Kiosk system presents the following menu options to the user:
1. Write "Hello World"
2. Write Current Date
3. Write OS Version

## BackgroundOperation Class
The `BackgroundOperation` class provides a method `WriteToFileAsync` to write messages to a file asynchronously. It has the following structure:

```csharp
public class BackgroundOperation
{
    public async Task WriteToFileAsync(string message)
    {
        await Task.Delay(3000); // Simulate a delay to mimic a blocking operation
        await File.WriteAllTextAsync("tmp.txt", message); // Write the message to a file asynchronously
    }
}
