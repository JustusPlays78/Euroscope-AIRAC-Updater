using System.IO;
using System.Text.Json;
using ES_AIRAC_PCKGE.EnumsList;

namespace ES_AIRAC_PCKGE.Services;

public class JsonService
{
    private readonly LoggerService _loggerService = new();

    private string ConfigPath = System.IO.Directory.GetCurrentDirectory() + "\\config.json";
    
    public ConfigService GetConfigJson()
    {
        ConfigService configs = JsonSerializer.Deserialize<ConfigService>(File.ReadAllText(ConfigPath));
        return configs;
    }

    public async Task SaveConfigJson(ConfigService configs)
    {
        await File.WriteAllTextAsync(ConfigPath, JsonSerializer.Serialize(configs));
    }

    public bool doesConfigJsonExist()
    {
        return File.Exists(ConfigPath);
    }
    
    public async Task CreateStandardConfigJson(ConfigService c)
    {
        _loggerService.LogMessage(SeverityLevelType.Info, "Creating new ConfigJson");
        await File.WriteAllTextAsync(ConfigPath, JsonSerializer.Serialize(c));
    }
}