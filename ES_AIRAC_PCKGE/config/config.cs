using System.IO;
using ES_AIRAC_PCKGE.Utils;
using utillogger = ES_AIRAC_PCKGE.Utils.Logger;

namespace ES_AIRAC_PCKGE.config;

public class Config
{
    public static string AppVersion = "1.0.0";
    public string VatsimUsername { get; set; }
    public string VatsimPassword { get; set; }
    public string[][][] FeatureArray { get; set; }
    public List<Boolean>? FeatureListBoolean { get; set; }
    
    private static Config cfg = new();
    


    public static void onConfigStart()
    {
        utillogger.LogMessage(SeverityLevel.Info,"Starting Configuration");
        if (!Json.doesConfigJsonExist())
        {
            utillogger.LogMessage(SeverityLevel.Error,"Configuration file doesn't exist");
            Json.CreateStandardConfigJson(GenereateStandardConfig());
            utillogger.LogMessage(SeverityLevel.Info,"Configuration created");
        }
        utillogger.LogMessage(SeverityLevel.Info,"Reading configuration file");
        cfg = Json.GetConfigJson();
    }

    private static Config GenereateStandardConfig()
    {
        Config config = new Config
        {
            VatsimUsername = "",
            VatsimPassword = "",
            FeatureArray = null,
            FeatureListBoolean = null,
        };
        return config;
    }
    
    private Config GetConfig()
    {
        if (!Json.doesConfigJsonExist())
        {
            utillogger.LogMessage(SeverityLevel.Error,"Configuration file doesn't exist");
            Json.CreateStandardConfigJson(GenereateStandardConfig());
            utillogger.LogMessage(SeverityLevel.Info,"Configuration created");
        }
        utillogger.LogMessage(SeverityLevel.Info,"Reading configuration file");
        return Json.GetConfigJson();
    }
    

    public static string GetAppVersion()
    {
        return AppVersion;
    }
    
}