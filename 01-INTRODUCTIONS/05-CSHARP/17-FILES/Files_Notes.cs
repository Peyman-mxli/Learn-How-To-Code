```csharp
using System;
using System.IO;

namespace LearnHowToCode.Files
{
    class FilesNotes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read the notes inside this file.");
        }
    }

    /*
        ============================================================
        FILES NOTES
        ============================================================

        In this module, I learn about Files in C#.

        Files allow programs to store data
        permanently outside of memory.

        Without files, most information is lost
        when the application closes.

        File handling is an essential skill for
        creating professional applications.
    */

    /*
        ============================================================
        1. WHAT IS A FILE?
        ============================================================

        A file is a collection of data stored
        on a storage device.

        Examples:

        - Text files (.txt)
        - CSV files (.csv)
        - JSON files (.json)
        - XML files (.xml)
        - Images (.png, .jpg)
        - Documents (.docx, .pdf)

        Files allow data to persist
        after a program ends.
    */

    /*
        ============================================================
        2. WHY FILES MATTER
        ============================================================

        Files are used for:

        ✔ Saving game progress

        ✔ User settings

        ✔ Reports

        ✔ Logs

        ✔ Databases

        ✔ Configuration files

        ✔ Data backups
    */

    /*
        ============================================================
        3. USING SYSTEM.IO
        ============================================================

        Most file operations use:

            using System.IO;

        This namespace contains classes
        for working with files and folders.
    */

    /*
        ============================================================
        4. FILE CLASS
        ============================================================

        The File class provides static methods
        for common file operations.

        Examples:

            File.ReadAllText()

            File.WriteAllText()

            File.AppendAllText()

            File.Exists()
    */

    /*
        ============================================================
        5. WRITING A FILE
        ============================================================

        Example:

            File.WriteAllText(
                "message.txt",
                "Hello World"
            );

        Result:

        Creates the file if it does not exist.

        Overwrites existing content if it exists.
    */

    /*
        ============================================================
        6. READING A FILE
        ============================================================

        Example:

            string text =
                File.ReadAllText("message.txt");

        Console.WriteLine(text);

        Reads all file content into a string.
    */

    /*
        ============================================================
        7. APPENDING TO A FILE
        ============================================================

        Example:

            File.AppendAllText(
                "log.txt",
                "New Entry"
            );

        Adds text to the end of the file.

        Existing content remains unchanged.
    */

    /*
        ============================================================
        8. CHECKING IF A FILE EXISTS
        ============================================================

        Example:

            bool exists =
                File.Exists("data.txt");

        if(exists)
        {
            Console.WriteLine("File Found");
        }

        Prevents file-related errors.
    */

    /*
        ============================================================
        9. DELETING A FILE
        ============================================================

        Example:

            File.Delete("oldfile.txt");

        Permanently removes the file.

        Use carefully.
    */

    /*
        ============================================================
        10. COPYING FILES
        ============================================================

        Example:

            File.Copy(
                "source.txt",
                "backup.txt"
            );

        Creates a duplicate file.
    */

    /*
        ============================================================
        11. MOVING FILES
        ============================================================

        Example:

            File.Move(
                "old.txt",
                "new.txt"
            );

        Moves or renames a file.
    */

    /*
        ============================================================
        12. FILE PATHS
        ============================================================

        Relative Path:

            data.txt

        Absolute Path:

            C:\Projects\data.txt

        Relative paths are commonly used
        in small applications.

        Absolute paths point to a specific
        location on the computer.
    */

    /*
        ============================================================
        13. DIRECTORY CLASS
        ============================================================

        The Directory class works with folders.

        Examples:

            Directory.CreateDirectory()

            Directory.Delete()

            Directory.Exists()
    */

    /*
        ============================================================
        14. CREATING A DIRECTORY
        ============================================================

        Example:

            Directory.CreateDirectory(
                "Reports"
            );

        Creates a folder if it
        does not already exist.
    */

    /*
        ============================================================
        15. READING ALL LINES
        ============================================================

        Example:

            string[] lines =
                File.ReadAllLines("data.txt");

        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }

        Reads each line separately.
    */

    /*
        ============================================================
        16. WRITING MULTIPLE LINES
        ============================================================
        
        Example:

            string[] names =
            {
                "Peyman",
                "John",
                "Sarah"
            };

            File.WriteAllLines(
                "students.txt",
                names
            );

        Writes multiple lines at once.
    */

    /*
        ============================================================
        17. FILE EXCEPTIONS
        ============================================================

        Common exceptions:

        FileNotFoundException

        UnauthorizedAccessException

        DirectoryNotFoundException

        IOException

        Exception handling should be used
        when working with files.
    */

    /*
        ============================================================
        18. FILE HANDLING WITH TRY-CATCH
        ============================================================

        Example:

            try
            {
                string text =
                    File.ReadAllText("data.txt");
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }

        Prevents application crashes.
    */

    /*
        ============================================================
        19. REAL-WORLD SOFTWARE
        ============================================================

        File handling is used in:

        - Video Games
        - Banking Systems
        - Websites
        - Desktop Applications
        - Mobile Apps
        - Reporting Systems

        Almost every application
        works with files.
    */

    /*
        ============================================================
        20. BEST PRACTICES
        ============================================================

        ✔ Check if files exist

        ✔ Use try-catch

        ✔ Create backups

        ✔ Use meaningful file names

        ✔ Validate file paths

        ✔ Avoid hardcoded paths

        ✔ Handle permissions properly
    */

    /*
        ============================================================
        SUMMARY
        ============================================================

        Files allow me to:

        - Save data
        - Load data
        - Create reports
        - Store settings
        - Manage application data

        File handling is one of the most
        important practical skills in C#
        development.
    */
}

/*
👤 Author: Peyman Miyandashti
📨 250161@upbc.edu.mx // mxli.peyman@gmail.com
📞 +526865090453
🎓 Polytechnic University of Baja California
💻 Information Technology Engineering & Digital Innovation
📍 From IRAN (Mexico)
📅 Year: 2026
🆔 ID: 250161
*/
```
