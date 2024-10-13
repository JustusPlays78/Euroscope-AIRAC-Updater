using System.IO;
using System.Net;
using System.Text.Json;
using System.Windows.Documents;
using ES_AIRAC_PCKGE.Utils;
using utillogger = ES_AIRAC_PCKGE.Utils.Logger;

namespace ES_AIRAC_PCKGE.config;

public class Json
{

    private static String ConfigPath = System.IO.Directory.GetCurrentDirectory() + "\\config.json";
    

    public static Config GetConfigJson()
    {
        Config configs = JsonSerializer.Deserialize<Config>(File.ReadAllText(ConfigPath));
        return configs;
    }

    public static void SaveConfigJson(Config configs)
    {
        File.WriteAllText(ConfigPath, JsonSerializer.Serialize(configs));
    }

    public static Boolean doesConfigJsonExist()
    {
        if (File.Exists(ConfigPath))
        {
            return true;
        } else {
            return false;
        }
    }
    

    public static void CreateStandardConfigJson(Config c)
    {
        utillogger.LogMessage(SeverityLevel.Info, "Creating new ConfigJson");
        File.WriteAllText(ConfigPath, JsonSerializer.Serialize(c));
    }
    
}