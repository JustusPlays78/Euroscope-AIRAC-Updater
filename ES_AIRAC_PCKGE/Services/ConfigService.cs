using ES_AIRAC_PCKGE.EnumsList;

namespace ES_AIRAC_PCKGE.Services;

public class ConfigService
{
    private LoggerService _loggerService = new();
    private JsonService _jsonService = new();
    
    
    private readonly string AppVersion = "1.0.0";
    private string? VatsimUsername { get; set; }
    private string? VatsimPassword { get; set; }
    
    private List<string>? FeatureListName { get; set; }
    private List<string>? FeatureListFileName { get; set; }
    private List<string>? FeatureListOld { get; set; }
    private List<string>? FeatureListNew { get; set; }
    private List<bool>? FeatureListBoolean { get; set; }
    private List<FeaturesType>? FeatureListTypes { get; set; }
    private List<string> FeatureListSpecialFeatureList { get; set; }
    private List<bool>? FeatureListSpecialFeatureBoolean { get; set; }
    private List<FeatureListSpecialType> FeatureListSpecialTypes { get; set; }

    public async void OnStart()
    {
        if (!_jsonService.doesConfigJsonExist())
        {
            await _jsonService.CreateStandardConfigJson(GenereateStandardConfig());
        }
    }

    private ConfigService GenereateStandardConfig()
    {
        ConfigService config = new ConfigService
        {
            VatsimUsername = "",
            VatsimPassword = "",
            FeatureListName = null,
            FeatureListFileName = null,
            FeatureListOld = null,
            FeatureListNew = null,
            FeatureListBoolean = null,
            FeatureListTypes = null,
            FeatureListSpecialFeatureList = null,
            FeatureListSpecialFeatureBoolean = null,
            FeatureListSpecialTypes = null,
        };
        return config;
    }
    
    public ConfigService GetConfig()
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
    public List<string> GetFeatureListName() => FeatureListName;
    public List<string> GetFeatureListFileName() => FeatureListFileName;
    public List<string> GetFeatureListOld() => FeatureListOld;
    public List<string> GetFeatureListNew() => FeatureListNew;
    public List<bool> GetFeatureListBoolean() => FeatureListBoolean;
    public List<FeaturesType> GetFeatureListTypes() => FeatureListTypes;
    public List<string> GetFeatureListSpecialFeatureList() => FeatureListSpecialFeatureList;
    public List<bool> GetFeatureListSpecialFeatureBoolean() => FeatureListSpecialFeatureBoolean;
    public List<FeatureListSpecialType> GetFeatureListSpecialTypes() => FeatureListSpecialTypes;

    public void SetFeatureListBoolean() => VatsimUsername = "1.0.0";

}