using System;
using System.Collections.Generic;
using System.Text;

namespace Tools;

public static class LogManager
{
    private const string LogFolderPath = "Log";

    public static string GetLogFolderPath()
    {
        return $"./{LogFolderPath}/{DateTime.Now.Month}";
    }

    public static string GetLogFilePath()
    {
        return $"{GetLogFolderPath()}/{DateTime.Now.Month}/{DateTime.Now:yyyy-MM-dd}.log";
    }

    public static void Log(string projectName,string functionName,string message) { 
        if (!System.IO.Directory.Exists(GetLogFolderPath()))
        {
            System.IO.Directory.CreateDirectory(GetLogFolderPath());
        }
        if (!System.IO.File.Exists(GetLogFilePath()))
        {
            System.IO.File.Create(GetLogFilePath()).Close();
        }
        //string logFilePath = GetLogFilePath();
        //string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{projectName}] [{functionName}] {message}";
        //System.IO.File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
    }
}
