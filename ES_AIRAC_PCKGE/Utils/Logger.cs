using System.IO;
using System.Net;
using System.Text.Json;
using ES_AIRAC_PCKGE.config;

namespace ES_AIRAC_PCKGE.Utils;

public class Logger
{
    public static String LogPath {get; private set;}
    private static String LogVersion {get; set;}
    
    public static void LoggerStart()
    {
        
        LogVersion = Config.GetAppVersion();
        String Logfile = GetLogFileStartString(LogVersion);
        if (!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\debuging"))
        {
            Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\debuging");
        }
        LogPath = System.IO.Directory.GetCurrentDirectory()+ "\\debuging\\log_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss") + ".txt";
        CreateLogFile(LogPath, Logfile);
    }
    
    public static void LogMessage(SeverityLevel severity, string message)
    {
        message = GetSeverityLevelString(severity) + (message);
        String reader = File.ReadAllText(LogPath);
        message = reader + Environment.NewLine + message;
        File.AppendAllText(LogPath, message);
    }

    private static string GetSeverityLevelString(SeverityLevel severity)
    {
        string dateTime = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss || ");
        switch (severity)
        {
            case SeverityLevel.Info: 
                return dateTime + "INFO: ";
            case SeverityLevel.Success:
                return dateTime + "SUCCESS: ";
            case SeverityLevel.Warning:
                return dateTime + "WARN: ";
            case SeverityLevel.Error:
                return dateTime + "ERROR: ";
        }
        return "";
    }

    public static void CreateLogFile(String path, String logfile = "")
    {
        File.WriteAllText(LogPath,logfile);
    }

    private static String GetLogFileStartString(string logversion)
    {
        
        String first = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss") + " || Log ES_AIRAC_PCKGE log.txt";
        String second = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss") + " || Author: Julscha - Version " + logversion;
        
        
        return first + Environment.NewLine + second;
    }


}