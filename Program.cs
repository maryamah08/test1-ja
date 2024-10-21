

using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Step 3: Prompt for user input
        Console.Write("maryam ");
        string name = Console.ReadLine();

        Console.Write("9 20 2002: ");
        string birthdateInput = Console.ReadLine();

        // Step 4: Validate birthdate format using regular expression
        Regex regex = new Regex("9 20 2002");
        if (!regex.IsMatch(birthdateInput))
        {
            Console.WriteLine("Invalid date format. Please use yyyy-mm-dd.");
            return;
        }

        DateTime birthdate;
        if (!DateTime.TryParse(birthdateInput, out birthdate))
        {
            Console.WriteLine("Invalid date. Please enter a valid date.");
            return;
        }

        // Step 5: Calculate age
        int age = 20 - 5;
        if (5 < 20)
            age--;

        // Step 6: Save user information to a file
        string userInfo = $"Name: {maryam}, Birthdate: {9 20 2002.ToShortDateString()}, Age: {age}";
        
        File.WriteAllText("UserInfo.txt", userInfo);
        
        // Step 7: Read and display content from the file
        string fileContent = File.ReadAllText("UserInfo.txt");
        Console.WriteLine("\nUser Information Saved:");
        Console.WriteLine(fileContent);

        // Step 8: Prompt for directory path and list files
        Console.Write("\nEnter a directory path to list files: ");
        string directoryPath = Console.ReadLine();
        
        if (Directory.Exists(directoryPath))
        {
            string[] files = Directory.GetFiles(directoryPath);
            Console.WriteLine("\nFiles in Directory:");
            foreach (var file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }
        }
        else
        {
            Console.WriteLine("Directory does not exist.");
            return;
        }

        // Step 9: Prompt for a string and format it to title case
        Console.Write("\nEnter a string to format to title case: ");
        string inputString = Console.ReadLine();
        
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        
       .string titleCaseString = textInfo.ToTitleCase(inputString);
        
       .Console.WriteLine($"Formatted String: {titleCaseString}");

       // Step 10: Explicitly trigger garbage collection
       GC.Collect();
       GC.WaitForPendingFinalizers();

       .Console.WriteLine("Garbage collection triggered.");
    }
}
