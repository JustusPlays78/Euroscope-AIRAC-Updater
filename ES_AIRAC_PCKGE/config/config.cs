using System.IO;

namespace ES_AIRAC_PCKGE.config;

public class Config
{
    public static string AppVersion = "1.0.0";
    public string AppPath { get; set; }
    private static String ConfigPath { get; set; }
    public List<string> FeaturesList { get; set; }
    
    public Config()
    {
    }

    private Config GetConfig()
    {
        if (!Json.doesConfigJsonExist())
        {
            //Falls file nicht existiert
        }
        
        return Json.GetConfig();
    }

    public static Config GetStandartConfig()
    {
        Config c = new Config();
        c.AppPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        //c.ConfigPath = System.IO.Directory.GetCurrentDirectory() + "\\config.json";
        return c;
    }

    public static string GetAppVersion()
    {
        return AppVersion;
    }

    public static string GetConfigPath()
    {
        return ConfigPath;
    }
    
}