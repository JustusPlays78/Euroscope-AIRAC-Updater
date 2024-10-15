﻿using ES_AIRAC_PCKGE.EnumsList;

namespace ES_AIRAC_PCKGE.Services;

public class ConfigService
{
    LoggerService _loggerService = new LoggerService();
    JsonService _jsonService = new JsonService();
    
    
    private readonly string AppVersion = "1.0.0";
    private string? VatsimUsername { get; set; }
    private string? VatsimPassword { get; set; }
    private string[][][]? FeatureArray { get; set; }
    private List<bool>? FeatureListBoolean { get; set; }

    public void OnStart()
    {
        _loggerService.LogMessage(SeverityLevelType.Info,"Starting Configuration");
        if (!_jsonService.doesConfigJsonExist())
        {
            _loggerService.LogMessage(SeverityLevelType.Error,"Configuration file doesn't exist");
            _jsonService.CreateStandardConfigJson(GenereateStandardConfig());
            _loggerService.LogMessage(SeverityLevelType.Info,"Configuration created");
        }
        _loggerService.LogMessage(SeverityLevelType.Info,"Reading configuration file");
    }

    private ConfigService GenereateStandardConfig()
    {
        ConfigService config = new ConfigService
        {
            VatsimUsername = "",
            VatsimPassword = "",
            FeatureArray = null,
            FeatureListBoolean = null,
        };
        return config;
    }
    
    private ConfigService GetConfig()
    {
        if (!_jsonService.doesConfigJsonExist())
        {
            _loggerService.LogMessage(SeverityLevelType.Error,"Configuration file doesn't exist");
            _jsonService.CreateStandardConfigJson(GenereateStandardConfig());
            _loggerService.LogMessage(SeverityLevelType.Info,"Configuration created");
        }
        _loggerService.LogMessage(SeverityLevelType.Info,"Reading configuration file");
        return _jsonService.GetConfigJson();
    }
    

    public string GetAppVersion() => AppVersion;
    public string GetVatsimUsername() => VatsimUsername;
    public string GetVatsimPassword() => VatsimPassword;
    public List<bool> GetFeatureListBoolean() => FeatureListBoolean;
    public string[][][] GetFeatureArray() => FeatureArray;
    
}