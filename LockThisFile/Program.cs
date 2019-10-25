using System;
using System.IO;

static public class FileUtilities
{
    public static void Main(string[] args)
    {
        string toLock;
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: LockThisFile <fully-qualified filename>");
            Console.WriteLine("Enter a fully-qualified filename:");
            toLock = Console.ReadLine();
        }
        else
        {
            toLock = args[0];
        }


        // "C:\\Users\\ll56150\\AppData\\Roaming\\Corp\\ClientCashManagement\\CCM.config";
        FileStream streamLocked;
        try
        {
            streamLocked = new FileStream(toLock, FileMode.Open, FileAccess.Read, FileShare.None);
            Console.WriteLine(toLock + " is locked.");
            Console.WriteLine("Press a Enter to unlock and end.");

            _ = Console.ReadLine();
            streamLocked.Close();
        }
        catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine(toLock + " was not found.");
            Console.WriteLine("Press a Enter to end.");
            _ = Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
            Console.WriteLine("Press a Enter to end.");
            _ = Console.ReadLine();
        }
    }
}

      
       
