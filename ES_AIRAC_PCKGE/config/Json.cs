using System.IO;
using System.Net;
using System.Text.Json;
using ES_AIRAC_PCKGE.Utils;

namespace ES_AIRAC_PCKGE.config;

public class Json
{

    public static Config GetConfig()
    {
        Config c = new Config();
        
        return c;
    }

    public static void UpdateConfigJson()
    {
        
    }

    public static void SaveConfigJson()
    {
        
    }

    public static void LoadConfigJson()
    {

    }

    public static void DeleteConfigJson()
    {
        
    }

    public static Task CreateStandardConfigJson(Config c)
    {
        Utils.Utils.Consolelogger(SeverityLevel.Info, "Creating new ConfigJson");
        string json = JsonSerializer.Serialize(c);
        Utils.Utils.Consolelogger(SeverityLevel.Info, json);
        File.WriteAllText(c.ConfigPath, json);
        
        
        return Task.CompletedTask;
    }
    
}