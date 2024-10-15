using System.IO;
using ES_AIRAC_PCKGE.EnumsList;

namespace ES_AIRAC_PCKGE.Services;

public class LoggerService
{
    
    public string LogPath {get; private set;}
    private string LogVersion {get; set;}
    
    public async void OnStart(ConfigService configService)
    {
        LogVersion = configService.GetAppVersion();
        string Logfile = GetLogFileStartString(LogVersion);
        if (!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\debuging"))
        {
            Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\debuging");
        }
        LogPath = System.IO.Directory.GetCurrentDirectory()+ "\\debuging\\log_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss") + ".txt";
        await CreateLogFile(LogPath, Logfile);
    }
    
    public void LogMessage(SeverityLevelType severity, string message)
    {
        File.AppendAllText(LogPath, Environment.NewLine + GetSeverityLevelString(severity) + message);
    }

    private string GetSeverityLevelString(SeverityLevelType severity)
    {
        string dateTime = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss || ");
        switch (severity)
        {
            case SeverityLevelType.Info: 
                return dateTime + "INFO: ";
            case SeverityLevelType.Success:
                return dateTime + "SUCCESS: ";
            case SeverityLevelType.Warning:
                return dateTime + "WARN: ";
            case SeverityLevelType.Error:
                return dateTime + "ERROR: ";
        }
        return "";
    }

    public Task CreateLogFile(String path, String logfile = "")
    {
        File.WriteAllText(LogPath,logfile);
        return Task.CompletedTask;
    }

    private string GetLogFileStartString(string logversion)
    {
        
        string first = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss") + " || Log ES_AIRAC_PCKGE log.txt";
        string second = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss") + " || Author: Julscha - Version " + logversion;
        
        
        return first + Environment.NewLine + second;
    }


}