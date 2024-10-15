using System.IO;
using System.Text.Json;
using ES_AIRAC_PCKGE.EnumsList;

namespace ES_AIRAC_PCKGE.Services;

public class JsonService
{
    private LoggerService _loggerService = new LoggerService();

    private string ConfigPath = System.IO.Directory.GetCurrentDirectory() + "\\config.json";
    

    public ConfigService GetConfigJson()
    {
        ConfigService configs = JsonSerializer.Deserialize<ConfigService>(File.ReadAllText(ConfigPath));
        return configs;
    }

    public void SaveConfigJson(ConfigService configs)
    {
        File.WriteAllText(ConfigPath, JsonSerializer.Serialize(configs));
    }

    public bool doesConfigJsonExist()
    {
        if (File.Exists(ConfigPath))
        {
            return true;
        } else {
            return false;
        }
    }
    

    public void CreateStandardConfigJson(ConfigService c)
    {
        _loggerService.LogMessage(SeverityLevelType.Info, "Creating new ConfigJson");
        File.WriteAllText(ConfigPath, JsonSerializer.Serialize(c));
    }
    
}