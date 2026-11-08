using System;
using System.Collections.Generic;
using System.Text;


namespace Tools;

public static class LogManager
{
    private const string LogFolderPath = "Log";

    public static string GetLogFolderPath()
    {
        return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, LogFolderPath, DateTime.Now.Month.ToString());
    }

    public static string GetLogFilePath()
    {
        string folder = GetLogFolderPath();
        if (!Directory.Exists(folder))
        {
            Directory.CreateDirectory(folder);
        }
        return Path.Combine(folder, $"{DateTime.Now:yyyy-MM-dd}.log");
    }

    public static void Log(string projectName, string functionName, string message)
    {
        if (!System.IO.Directory.Exists(GetLogFolderPath()))
        {
            System.IO.Directory.CreateDirectory(GetLogFolderPath());
        }
        if (!System.IO.File.Exists(GetLogFilePath()))
        {
            System.IO.File.Create(GetLogFilePath()).Close();
        }
        System.IO.File.AppendAllText(GetLogFilePath(), $"{DateTime.Now}\t{projectName}.{functionName}:\t{message}");
    }
    public static void CleanOldLogFolders()
    {
        string logFolderPath = GetLogFolderPath();
        if (System.IO.Directory.Exists(logFolderPath))
        {
            string[] subDirectories = System.IO.Directory.GetDirectories(logFolderPath);

            foreach (string dirPath in subDirectories)
            {
                System.IO.DirectoryInfo dirInfo = new System.IO.DirectoryInfo(dirPath);

                if (dirInfo.CreationTime < DateTime.Now.AddMonths(-2))
                {
                    try
                    {
                        dirInfo.Delete(true);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Failed to delete log directory {dirInfo.Name}: {ex.Message}");
                    }
                }
            }
        }
    }
}


